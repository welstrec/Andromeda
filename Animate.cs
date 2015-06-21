using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using MikuDash;
using System.IO;



public class Animate
{
    private List<Bitmap> animSleep;
    private List<List<FileInfo>> animSing;
    private List<List<FileInfo>> animPoint;
    private List<List<FileInfo>> animStartle;
    private List<List<FileInfo>> animTrans;
    private List<List<FileInfo>> animWake;
    private List<List<FileInfo>> animListenFromSing;
    private List<List<FileInfo>> animListenFromWake;
    private List<List<FileInfo>> animListenLoop;
    private List<List<FileInfo>> animCancelListen;
    private List<List<FileInfo>> animCommand;
    private List<List<FileInfo>> animWakeSleep;



    public MikuAnim  frame;
    public MikuDashMain frameMain;
    public Listener lstnr;
    private CommandImpl cmdExec;
    public List<int> cmdStack = new List<int>();
    public List<String[]> programCmds = new List<String[]>();

    public Boolean sing = false;
    public Boolean sleep = false;
    public Boolean listen = false;
    public Boolean command = false;
    public Boolean animLock = true;
    public Boolean listenLock = true;
    public Boolean cmdExecuted = false;
    public Boolean stackCmdLoaded = false;
    public int cmdId = 0;
    public SpeechRecognizer sprs;
    public int selectedDance = 0;
    public Random rndDance = new Random();

    public Animate(MikuAnim frame, MikuDashMain framem, List<Bitmap> animSleep, List<List<FileInfo>> animSing, List<List<FileInfo>> animPoint, List<List<FileInfo>> animStartle, List<List<FileInfo>> animTrans, List<List<FileInfo>> animWake, List<List<FileInfo>> animListenFromSing, List<List<FileInfo>> animListenFromWake, List<List<FileInfo>> animListenLoop, List<List<FileInfo>> animCancelListen, List<List<FileInfo>> animCommand, List<List<FileInfo>> animWakeSleep, Listener ls, SpeechRecognizer spr, CommandImpl cmdImpl)
    {
        lstnr = ls;
        sprs = spr;
        cmdExec = cmdImpl;
        this.animSleep = animSleep;
        this.animSing = animSing;
        this.animPoint = animPoint;
        this.animStartle = animStartle;
        this.animTrans = animTrans;
        this.frame = frame;
        this.frameMain = framem;
        this.animWake = animWake;
        this.animListenFromSing = animListenFromSing;
        this.animListenFromWake = animListenFromWake;
        this.animListenLoop = animListenLoop;
        this.animCancelListen = animCancelListen;
        this.animCommand = animCommand;
        this.animWakeSleep = animWakeSleep;


    }
    public delegate void changeBox(Bitmap img);
    public delegate void changePlay(String pl);
    
    
    public void executeCommand(){
        Console.WriteLine("cmdsz: " + cmdStack.Count);
        Console.WriteLine("prgsz: " + programCmds.Count);
  
        foreach (int cmde in cmdStack)
        {
            System.Threading.Thread.Sleep(20);
            Console.WriteLine("     >" + cmde);
            switch (cmde)
            {
                case 2:
                    cmdExec.disableListener();
                    break;
                case 3:
                    cmdExec.mute();
                   
                    break;
                case 4:
                    cmdExec.volumeUp();
                    break;
                case 5:
                    cmdExec.volumeDown();
                    break;
                case 6:
                    cmdExec.turnOnScreens();
                    break;
                case 7:
                    cmdExec.turnOffScreens();
                    break;
                case 8:
                    cmdExec.hide();
                    break;
                case 9:
                    cmdExec.unMute();
                    break;
                case 10:
                    cmdExec.show();
                    break;
                

            }
        }

        foreach (String[] strp in programCmds)
        {
            Console.WriteLine("     >" + strp[0]);
            if (strp[2].Equals("inter"))
            {
                cmdExec.openBrowser(strp[1]);
            }
            else
            {
                cmdExec.openApp(strp[1]);
            }
        }

        cmdStack.Clear();
        programCmds.Clear();
        stackCmdLoaded = false;
        cmdExecuted = true;
    }
    
    public void wakeUpAndSingOrListen(){
        animLock = true;
        //frame.BeginInvoke(new changePlay(frame.changePlay), new Object[] { ">>" });

        if (listen)
        {
            doWake();
            listenFromWake();
        }
        else if (sing)
        {
            doStartle();
            doSing();
        }
        else
        {
            doSleep();
        }
        
        
        
        
        
    }
    public void doStartle()
    {
        selectedDance = rndDance.Next(0, animStartle.Count); // creates a number between 1 and 12

        for (int i = 0; i < animStartle[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animStartle[selectedDance][i].FullName) });

        }
    }

    public void doWake()
    {
     
        selectedDance = rndDance.Next(0, animWake.Count); // creates a number between 1 and 12

        for (int i = 0; i < animWake[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animWake[selectedDance][i].FullName) });

        }
    }
    public void listenFromSing()
    {
        
        selectedDance = rndDance.Next(0, animListenFromSing.Count); // creates a number between 1 and 12
           
        for (int i = 0; i < animListenFromSing[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animListenFromSing[selectedDance][i].FullName) });

        }
       
        listenLoop();

    }

    public void listenFromWake()
    {
        
        selectedDance = rndDance.Next(0, animListenFromWake.Count); // creates a number between 1 and 12

        for (int i = 0; i < animListenFromWake[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animListenFromWake[selectedDance][i].FullName) });

        }
        
        listenLoop();

    


    }

    public void cancelListenToWake()
    {
        selectedDance = rndDance.Next(0, animCancelListen.Count); // creates a number between 1 and 12

        for (int i = 0; i < animCancelListen[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animCancelListen[selectedDance][i].FullName) });

        }

        wakeToSleep();
    }

    public void doCommand()
    {
        selectedDance = rndDance.Next(0, animCommand.Count); // creates a number between 1 and 12

        for (int i = 0; i < animCommand[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animCommand[selectedDance][i].FullName) });

        }
        executeCommand();
        listen = true;
        command = false;
        listenLoop();
    }

    public void wakeToSleep()
    {
        selectedDance = rndDance.Next(0, animWakeSleep.Count); // creates a number between 1 and 12

        for (int i = 0; i < animWakeSleep[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animStartle[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animWakeSleep[selectedDance][i].FullName) });

        }
        doSleep();
    }

    public void goSleepOrListen()
    {
        animLock = true;
        frame.normalRegion();
        
       //frame.BeginInvoke(new changePlay(frame.changePlay), new Object[] { "" });
  
        doPoint();
        if(listen){
            listenFromSing();

        }else{
            
            doTrans();
    
            doSleep();
        }
    }
    public void doTrans()
    {
        selectedDance = rndDance.Next(0, animTrans.Count); // creates a number between 1 and 12

        for (int i = 0; i < animTrans[selectedDance].Count; i++)
        {

            System.Threading.Thread.Sleep(20);
            //frame.changeBox(animTrans[i]);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animTrans[selectedDance][i].FullName) });

        }
    }
    public void doPoint()
    {
      
        frame.normalRegion();
        selectedDance = rndDance.Next(0, animPoint.Count); // creates a number between 1 and 12
            
            for (int i = 0; i < animPoint[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(20);
                //frame.changeBox(animPoint[i]);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animPoint[selectedDance][i].FullName) });

            }
            
        
      
    }
    public void doSleep()
    {
   
        frame.normalRegion();
        
        while (sleep && !listen)
        {
            animLock = false;
            System.Threading.Thread.Sleep(50);
            for (int i = 0; i < animSleep.Count; i++)
            {
                //frame.changeBox(animSleep[i]);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { animSleep[i] });
                System.Threading.Thread.Sleep(50);
            }
                
            
        }
        wakeUpAndSingOrListen();
        
    }

    public void doSing()
    {
        
        frame.normalRegion();
       
        //frame.BeginInvoke(new changePlay(frame.changePlay), new Object[] { ">>" });
        while (sing && !listen)
        {
            animLock = false;
            System.Threading.Thread.Sleep(20);
            selectedDance = rndDance.Next(0, animSing.Count); // creates a number between 1 and 12
            
            for (int i = 0; i < animSing[selectedDance].Count; i++)
            {
                
                //frame.changeBox(animSing[i]);
                //frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { animSing[i] });
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animSing[selectedDance][i].FullName) });
                
                System.Threading.Thread.Sleep(20);
            }

        }
     
        goSleepOrListen();
    }


    public void listenLoop()
    {
        selectedDance = rndDance.Next(0, animListenLoop.Count); // creates a number between 1 and 12
        
        while (listen)
        {
            selectedDance = rndDance.Next(0, animListenLoop.Count); // creates a number between 1 and 12
        
            animLock = false;
            listenLock = false;
            for (int i = 0; i < animListenLoop[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(20);
                //frame.changeBox(animStartle[i]);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(animListenLoop[selectedDance][i].FullName) });

            }
            
        }
        listenLock = true;
        animLock = true;
        if (command)
        {
            doCommand();
        }
        else
        {
            cancelListenToWake();
        }
        
    }
       
}

