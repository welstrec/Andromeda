using System;
using System.Collections.Generic;

using System.Drawing;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;
using MikuDash;
using System.Net.NetworkInformation;
using Andromeda;


class Clock
{

    public bool runLoop = true;
    private MikuDashMain frame;
    public bool date = false;
    private bool dots = false;
    private int reloadMonitor = 80;
    private long lastnetsend;
    private long lastnetin;
    private HWMonitor pcMonitor;

   
    List<Bitmap> days = new List<Bitmap>();
    
    public Clock(MikuDashMain frm, List<Bitmap> dates)
    {
        frame = frm;
        days = dates;
        pcMonitor = new HWMonitor();   


    }
    public delegate void setClock(String time, bool date, bool dot);
    public delegate void setDate(Bitmap time, Bitmap month,String yr);
    public void getTime()
    {
        pcMonitor.initialize();
        while (runLoop)
        {
            try
            {
                
                String data = "";
                if (!date)
                {
                    data = DateTime.Now.ToString("hh;mm;tt");
                    frame.BeginInvoke(new setClock(frame.setClock), new Object[] { data, date, dots });


                }
                else
                {
                    data = DateTime.Now.ToString("dd;MM;yy;ddd");
                    frame.BeginInvoke(new setClock(frame.setClock), new Object[] { data, date, dots });

                }
                int daynum = DateTime.Now.Day;
                frame.BeginInvoke(new setDate(frame.setDate), new Object[] { days[daynum], days[DateTime.Now.Month], DateTime.Now.ToString("yyyy") });


                dots = !dots;

                
                    

                    if (reloadMonitor == 100)
                    {
                        pcMonitor.disposeMonitor();
                        pcMonitor.initialize();
                      
                    }
                
                    monitorSystem();
                     
                System.Threading.Thread.Sleep(700);
                reloadMonitor++;
                
            }
            catch (Exception e)
            {
               
            }
        }
    }
    public delegate void setMonitor(List<CUMonitorUpdate> monitorUpd, int numProc, String netstat);
    public void monitorSystem()
    {


               
          
                String netstat = "No LAN Connection";
                if (NetworkInterface.GetIsNetworkAvailable())
                {


                    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                    long ulTotal=0;
                    long dlTotal = 0;
                    foreach (NetworkInterface ni in interfaces)
                    {
                    
                   // Console.WriteLine("Sent:" + ni.GetIPv4Statistics().BytesSent+" Name: "+ni.Name);
                    
                    

                    ulTotal += ni.GetIPv4Statistics().BytesSent;
                    dlTotal += ni.GetIPv4Statistics().BytesReceived;                   
                    
                       
                    }
                    
                    //Console.WriteLine("TT:" + (ulTotal) + "BK:" + lastnetsend);
                    netstat = "UL: " + ((ulTotal - lastnetsend)/1000) + " KBPS\nDL: " + ((dlTotal - lastnetin)/1000) + " KBPS\n";
                    lastnetsend = ulTotal;
                    lastnetin = dlTotal;
            

        }


                frame.BeginInvoke(new setMonitor(frame.setMonitor), new Object[] {pcMonitor.updateHardwareStats(), System.Diagnostics.Process.GetProcesses().Length, netstat});
                //System.Threading.Thread.Sleep(700);

            }
        
       

    }


