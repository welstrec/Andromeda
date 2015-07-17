using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAudioApi;
using System.Threading;
using MikuDash;

public class Listener
{
    private MMDevice device;
    private Animate mikuAnim;
    private Thread moveMiku;
    private SpeechRecognizer spRec;
    private DateSound mdm;
    public bool tListen = true;

    private int devDel = 0;
    public delegate void topmostApp();
    public Listener(Animate anim,SpeechRecognizer spr, DateSound mdm)
    {
        this.mdm = mdm;
        mikuAnim = anim;
        mikuAnim.sing = false;
        mikuAnim.sleep = true;
        spRec = spr;
         moveMiku = new Thread(new ThreadStart(mikuAnim.doWelcome));
         moveMiku.Start();
        
         //getSession();
    }
    public void stopAnim()
    {
        
        moveMiku.Abort();
        mikuAnim.sing = false;
        mikuAnim.sleep = false;
       
        

    }

    public delegate void setLevel(int valL, int valR, int l, int r, int c, int sl, int sr, int rl, int rr, int sw);
    public delegate void listenerLedOper();
    public void listen()
    {
       
           
            try
            {
                getSession();
            }
            catch (Exception e)
            {
                
            }
            while (tListen)
            {
                try
                {

                    System.Threading.Thread.Sleep(500);
                    devDel++;
              
                    int val = 0;
                    int lc = 0;
                    //4800
                    if (devDel == 1500)
                    {
                       
                        getSession();
                        devDel = 0;
                        mikuAnim.frameMain.BeginInvoke(new topmostApp(mikuAnim.frameMain.topmostApp), new Object[] { });

                    }

                    val = (int)(device.AudioMeterInformation.MasterPeakValue * 100);
                        lc = (int)(device.AudioMeterInformation.PeakValues.Count);

                    int l = 0;
                    int r = 0;
                    int c = 0;
                    int sl = 0;
                    int sr = 0;
                    int rr = 0;
                    int rl = 0;
                    int sw = 0;

                    if (lc == 1)
                    {
                        c = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                    }
                    else if (lc == 2)
                    {

                    l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                    r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                    }
                    else if (lc == 3) { 
                     c = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                     l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                     r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                    }
                    else if (lc == 4) {
                        
                        l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                        r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                       sl = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                        sr = (int)((device.AudioMeterInformation.PeakValues[3]) * 100);
                    }else if(lc == 5){
                        l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                        r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                        c = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                        sl = (int)((device.AudioMeterInformation.PeakValues[3]) * 100);
                        sr = (int)((device.AudioMeterInformation.PeakValues[4]) * 100);
                    }
                    else if (lc == 6) {
                        l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                        r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                        c = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                        sw = (int)((device.AudioMeterInformation.PeakValues[3]) * 100);
                        sl = (int)((device.AudioMeterInformation.PeakValues[4]) * 100);
                        sr = (int)((device.AudioMeterInformation.PeakValues[5]) * 100);
                    }
                    else if (lc == 7) {
                        l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                        r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                        c = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                        sl = (int)((device.AudioMeterInformation.PeakValues[3]) * 100);
                        sr = (int)((device.AudioMeterInformation.PeakValues[4]) * 100);
                        rl = (int)((device.AudioMeterInformation.PeakValues[5]) * 100);
                        rr = (int)((device.AudioMeterInformation.PeakValues[6]) * 100);
                        
                    }
                    else if (lc == 8)
                    {
                        l = (int)((device.AudioMeterInformation.PeakValues[0]) * 100);
                        r = (int)((device.AudioMeterInformation.PeakValues[1]) * 100);
                        c = (int)((device.AudioMeterInformation.PeakValues[2]) * 100);
                        sl = (int)((device.AudioMeterInformation.PeakValues[4]) * 100);
                        sr = (int)((device.AudioMeterInformation.PeakValues[5]) * 100);
                        rl = (int)((device.AudioMeterInformation.PeakValues[6]) * 100);
                        rr = (int)((device.AudioMeterInformation.PeakValues[7]) * 100);
                        sw = (int)((device.AudioMeterInformation.PeakValues[3]) * 100);
                    }

                    //onsole.WriteLine(l + " - " + r + " - " +c+ " - " +sl+ " - " +sr+ " - " +rl+ " - " +rr+ " - " +sw);
                   
                
                    


                    mdm.BeginInvoke(new setLevel(mikuAnim.frameMain.soundDate.setLevel), new Object[] { val, lc,l,r,c,sl,sr,rl,rr,sw});

                    if (spRec.active)
                    {

                        if (!mikuAnim.animLock)
                        {
                            mdm.BeginInvoke(new listenerLedOper(mdm.listenerLedOn));
                            mikuAnim.sleep = false;
                            mikuAnim.sing = false;
                            mikuAnim.listen = true;

                            if (spRec.cmdId == -1 && spRec.cmdStack.Count == 0 && spRec.programCmds.Count == 0)
                            {
                                mikuAnim.listen = false;
                                spRec.listened = false;
                                spRec.cmdLock = false;
                                mikuAnim.command = false;
                                mikuAnim.sleep = true;
                                spRec.active = false;
                                mdm.BeginInvoke(new listenerLedOper(mdm.listenerLedOff));
                               
                            }
                            else if (spRec.cmdStack.Count != 0 || spRec.programCmds.Count != 0)
                            {

                               
                                mikuAnim.cmdStack = spRec.cmdStack.ToList();
                                mikuAnim.programCmds = spRec.programCmds.ToList();


                                if (!mikuAnim.listenLock)
                                {
                                    mikuAnim.listen = false;

                                    spRec.listened = false;
                                    mikuAnim.cmdId = spRec.cmdId;

                                    if (mikuAnim.cmdExecuted)
                                    {
                                        if (spRec.cmdId != -1)
                                        {
                                            spRec.cmdId = 0;
                                        }
                                        spRec.cmdStack.Clear();
                                        spRec.programCmds.Clear();
                                        mikuAnim.frameMain.BeginInvoke(new topmostApp(mikuAnim.frameMain.topmostApp), new Object[] { });
                                        mikuAnim.cmdExecuted = false;
                                    }

                                    mikuAnim.command = true;
                                    spRec.cmdLock = false;


                                }


                            }
                        }
                        else
                        {

                            mdm.BeginInvoke(new listenerLedOper(mdm.listenLedBlink));
                        }
                        
                        //executecmd
                        



                    }
                    else
                    {


                        //if (animDel == 20)
                        //{


                            //System.Windows.Forms.MessageBox.Show("-->" + val);

                            if (val > 1)
                            {
                                mikuAnim.listen = false;
                                mikuAnim.sing = true;
                                mikuAnim.sleep = false;
                                /*
                                if (!singing)
                                {

                                
                                    /* moveMiku.Abort();
                                    if (mikuAnim.locked)
                                    {
                                       // moveMiku = new Thread(new ThreadStart(mikuAnim.doSing));
                                    }
                                    else
                                    {
                                        moveMiku = new Thread(new ThreadStart(mikuAnim.wakeUpAndSing));
                                    }
                               
                                }*/
                            }
                            else
                            {
                                mikuAnim.listen = false;
                                mikuAnim.sing = false;
                                mikuAnim.sleep = true;
                                /*
                                if (singing)
                                {
                                
                                   /* moveMiku.Abort();
                                    moveMiku = new Thread(new ThreadStart(mikuAnim.goSleep));
                                    moveMiku.Start();
                                    singing = false;
                                
                                
                                }*/
                            }



                        
                       
                      
                    }
                }
                catch (Exception e)
                {
                    //System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }

        
    }

    public void volumeUp()
    {
        device.AudioEndpointVolume.VolumeStepUp();
    }

    public void volumeDown()
    {
        device.AudioEndpointVolume.VolumeStepDown();
    }

    public void mute()
    {
        device.AudioEndpointVolume.Mute = true;
    }

    public void resume()
    {
        device.AudioEndpointVolume.Mute = false;
    }
    public void getSession()
    {
        
        MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
        device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
        Console.WriteLine(device.AudioEndpointVolume.Channels[0].GetType());
        
    }
}

