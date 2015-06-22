using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;
using MikuDash;


class clock
{
    private MikuDashMain frame;
    public bool date = false;
    private bool dots = false;
    PerformanceCounter cpuCounter;
    PerformanceCounter ramCounter;
    Computer cpt;
    List<Bitmap> days = new List<Bitmap>();
    
    public clock(MikuDashMain frm, List<Bitmap> dates)
    {
        frame = frm;
        days = dates;
       
        cpuCounter = new PerformanceCounter();

        cpuCounter.CategoryName = "Processor";
        cpuCounter.CounterName = "% Processor Time";
        cpuCounter.InstanceName = "_Total";
        ramCounter = new PerformanceCounter();
        ramCounter.CounterName = "% Committed Bytes In Use";
        ramCounter.CategoryName = "Memory";

        cpt = new Computer() { MainboardEnabled = true, GPUEnabled = true, CPUEnabled = true };

        cpt.Open();



    }
    public delegate void setClock(String time, bool date, bool dot);
    public delegate void setDate(Bitmap time, String month,String yr);
    public void getTime()
    {
        while (true)
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
                frame.BeginInvoke(new setDate(frame.setDate), new Object[] { days[daynum], DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy") });


                dots = !dots;
                System.Threading.Thread.Sleep(700);

            }
            catch (Exception e)
            {
            }
        }
    }
    public delegate void setMonitor(int valCPU, int valRAM, int valCPUT, int valCPUF, int valGPU, int valVRam, int valGPUT, int valGPUF, double valGPUCLK, double valCPUCLK);
    public void monitorSystem()
    {
        try
        {
            int cput = 0;
            int cpuf = 0;
            int gpu = 0;
            int vram = 0;
            int gput = 0;
            int gpuf = 0;

            double cpuclk = 0;
            double gpuclk = 0;
            double cpuclkThick = 0;
            double cpuclkcounter = 0;

            while (true)
            {


                foreach (var hardwareItem in cpt.Hardware)
                {
                    if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                    {

                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                            subHardware.Update();
                        
                        foreach (var sensor in hardwareItem.Sensors)
                        {   
                            if (sensor.SensorType == SensorType.Clock && sensor.Name.ToLower().Contains("core"))
                            {

                                gpuclk  = sensor.Value.HasValue ? (Convert.ToDouble(sensor.Value)) : 0;


                            }

                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToLower().Contains("core"))
                            {

                                gput = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;


                            }
                            if (sensor.SensorType == SensorType.Fan && sensor.Name.ToLower().Contains("gpu"))
                            {
                                
                                gpuf = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;


                            }

                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("core"))
                            {

                                gpu = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;


                            }
                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("memory"))
                            {

                                vram = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;


                            }
                        }
                    }
                   if (hardwareItem.HardwareType == HardwareType.CPU)
                    {

                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                        
                                     subHardware.Update();
                       
                            foreach (var sensor in hardwareItem.Sensors)
                            {
                                
                                if (sensor.SensorType == SensorType.Clock && sensor.Name.ToLower().Contains("core"))
                                {

                                    cpuclkThick  += sensor.Value.HasValue ? (Convert.ToInt32(sensor.Value)) : 0;
                                    cpuclkcounter =  sensor.Value.HasValue ? cpuclkcounter + 1 : 0;
                                    
                                }
                                

                                if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToLower().Contains("pack"))
                                {

                                    cput = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;


                                }
                                
                            }
                        
                    }
                
                    if (hardwareItem.HardwareType == HardwareType.Mainboard)
                    {

                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                        {
                            subHardware.Update();

                            int conectedFan = 2;
                            foreach (var sensor in subHardware.Sensors)
                            {


                                if (sensor.SensorType == SensorType.Fan && sensor.Name.ToLower().Contains("fan"))
                                {

                                    conectedFan = Convert.ToInt32(sensor.Name.Split('#')[1]);


                                }
                                if (sensor.SensorType == SensorType.Fan && sensor.Name.ToLower().Contains("#" + conectedFan))
                                {

                                    cpuf = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 0;
                                

                                }
                            }
                        }
                    }
                }
                
                cpuclk = (cpuclkThick / cpuclkcounter);
                cpuclk = Math.Round(cpuclk , 0);
                gpuclk = Math.Round(gpuclk , 0);
                cpuclkcounter = 0;
                cpuclkThick = 0;
                frame.BeginInvoke(new setMonitor(frame.setMonitor), new Object[] { (int)cpuCounter.NextValue(), (int)ramCounter.NextValue(), cput, cpuf, gpu,vram, gput, gpuf,gpuclk,cpuclk   });
                System.Threading.Thread.Sleep(700);

            }
        }
        catch (Exception e)
        {
            //System.Windows.Forms.MessageBox.Show(e.Message);

        }

    }
}

