using System;
using System.Collections.Generic;
using System.Drawing;
using MikuDash;
using System.IO;



public class Animate
{



    public static int ANIM_SPEED = 35;
    private List<Bitmap> animSleep;
    private List<List<FileInfo>> animSing;
    private List<List<FileInfo>> animIdle;
    private List<List<FileInfo>> animlisten;
    private List<List<FileInfo>> animSleepToIdle;
    private List<List<FileInfo>> animIdleToSing;
    private List<List<FileInfo>> animIdleToListen;
    private List<List<FileInfo>> animDoCommand;
    private List<List<FileInfo>> animListenToIdle;
    private List<List<FileInfo>> animSingToIdle;
    private List<List<FileInfo>> animIdleToSleep;
    private List<List<FileInfo>> animWelcome;


    private List<List<FileInfo>> animTurnLeftSinging;
    private List<List<FileInfo>> animTurnRightSinging;
    private List<List<FileInfo>> animWalkLeftSinging;
    private List<List<FileInfo>> animWalkRightSinging;
    private List<List<FileInfo>> animStopTurnLeftSinging;
    private List<List<FileInfo>> animStopTurnRightSinging;

    private List<List<FileInfo>> animTurnLeftIdling;
    private List<List<FileInfo>> animTurnRightIdling;
    private List<List<FileInfo>> animWalkLeftIdling;
    private List<List<FileInfo>> animWalkRightIdling;
    private List<List<FileInfo>> animStopTurnLeftIdling;
    private List<List<FileInfo>> animStopTurnRightIdling;

    public double[] walkCords;

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
    public Boolean notify = false;
    public Boolean walk = false;
    public Boolean walking = false;


    public Boolean animLock = true;
    public Boolean listenLock = true;
    public Boolean cmdExecuted = false;
    public Boolean stackCmdLoaded = false;
    public int cmdId = 0;
    public SpeechRecognizer sprs;
    public int selectedDance = 0;
    public int danceDelay = 1;
    public Random rndDance = new Random();

    public Animate(MikuAnim frame, MikuDashMain framem,    List<Bitmap> animSleep,   List<List<FileInfo>> animSing,   List<List<FileInfo>> animIdle,   List<List<FileInfo>> animlisten,   List<List<FileInfo>> animSleepToIdle,   List<List<FileInfo>> animIdleToSing,   List<List<FileInfo>> animIdleToListen,   List<List<FileInfo>> animDoCommand,    List<List<FileInfo>> animListenToIdle,    List<List<FileInfo>> animSingToIdle,    List<List<FileInfo>> animIdleToSleep,List<List<FileInfo>> animWelcome,   Listener ls, SpeechRecognizer spr, CommandImpl cmdImpl)
    {
        lstnr = ls;
        sprs = spr;
        cmdExec = cmdImpl;
        this.animSleep = animSleep;
        this.animSing = animSing;
        this.animIdle = animIdle;
        this.animlisten = animlisten;
        this.animSleepToIdle = animSleepToIdle;
        this.frame = frame;
        this.frameMain = framem;
        this.animIdleToSing = animIdleToSing;
        this.animIdleToListen = animIdleToListen;
        this.animDoCommand = animDoCommand;
        this.animListenToIdle = animListenToIdle;
        this.animSingToIdle = animSingToIdle;
        this.animIdleToSleep = animIdleToSleep;
        this.animWelcome = animWelcome;


    }
    public delegate void changeBox(Bitmap img);
    public delegate void changePlay(String pl);



    public void playAnimation(List<List<FileInfo>> histo,Boolean switchAnim)
    {
        if (switchAnim)
        {
            selectedDance = rndDance.Next(0, histo.Count);
        }

        
            for (int i = 0; i < histo[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(ANIM_SPEED);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(histo[selectedDance][i].FullName) });

            }
        

    }

    public void playAnimationMoveFrame(List<List<FileInfo>> histo, Boolean switchAnim, int offset)
    {
        if (switchAnim)
        {
            selectedDance = rndDance.Next(0, histo.Count);
        }


        for (int i = 0; i < histo[selectedDance].Count; i++)
        {
            System.Threading.Thread.Sleep(ANIM_SPEED);
            frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(histo[selectedDance][i].FullName) });
            frame.Top = frame.Location.X + offset;
        }


    }

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
    
    public void decideFromSleep(){
        animLock = true;
    

        if (listen)
        {
            doIdleToListen();
        }
        else if (sing)
        {
            doIdleToSing();
        }
        
        else
        {
            idleLoop();
        }
        
     
    
        
        
    }

    public void decideFromSing()
    {
        animLock = true;


        if (sing && !listen)
        {
            singLoop ();
        }
        else if (listen)
        {
            decideFromListen ();
        }
        else
        {
            doSingToIdle();
        }

    }


    public void decideFromListen()
    {
        listenLock = true;
        animLock = true;
        if (command)
        {
            doCommand();
        }
        else if (listen)
        {
            listenLoop();
        }
        else if (sing)
        {
            decideFromSing();
        }
        else
        {
            doListenToIdle ();
        }
    }

    public void decideFromIdle()
    {
        animLock = true;


        if (listen)
        {
            doIdleToListen();
        }
        else if (sing)
        {
            doIdleToSing();
        }

        else
        {
            doIdleToSleep();
        }

    }
    public void doWelcome()
    {
        System.Threading.Thread.Sleep(800);
        animLock = true;
        playAnimation(animWelcome, true);
        idleLoop();
    }


    public void doSleepToIdle()
    {
        animLock = true;
        playAnimation(animSleepToIdle,true);
        decideFromSleep();
    }

    public void doIdleToSing()
    {
        animLock = true;
        playAnimation(animIdleToSing, true);
        decideFromSing();
        
    }
   
    public void doIdleToListen()
    {
        animLock = true;
        playAnimation(animIdleToListen, true);
        decideFromListen();
    }
    public void doCommand()
    {
        animLock = true;
        playAnimation(animDoCommand, true);
        executeCommand();
        listen = true;
        command = false;
        decideFromListen();
    }

    public void doListenToIdle()
    {
        animLock = true;
        playAnimation(animListenToIdle, true);
        idleLoop();
    }

    public void doSingToIdle()
    {
        animLock = true;
        playAnimation(animSingToIdle, true);
        idleLoop();
    }

    public void doIdleToSleep()
    {
        animLock = true;
        playAnimation(animIdleToSleep, true);
        sleepLoop();
    }


    public void idleLoop()
    {

        frame.normalRegion();
        int to = 0;
        while (!listen && !sing && !notify && to < 7)
        {
            animLock = false;
            if (walk)
            { }
            else
            {
                playAnimation(animIdle, true);
            }
            to++;

        }

        decideFromIdle();

    }

    public void sleepLoop()
    {
   
        frame.normalRegion();
        
        while (sleep && !listen && !sing && !notify)
        {
            animLock = false;
            System.Threading.Thread.Sleep(ANIM_SPEED);
            for (int i = 0; i < animSleep.Count; i++)
            {                
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { animSleep[i] });
                System.Threading.Thread.Sleep(50);
            }
                
            
        }

        doSleepToIdle();
        
        
    }

    public void singLoop()
    {
        
        frame.normalRegion();
       
        int t = 1;
        while (sing && !listen && !notify)
        {
            animLock = false;

            if(t ==danceDelay){
                danceDelay = rndDance.Next(1, 6);
                if (walk)
                {
                    walkLogic();
                }else{
                    playAnimation(animSing, true);
                }
                t=0;
            }else{

                if (walk)
                { 
                    walkLogic(); 
                }
                else
                {
                   playAnimation(animSing, false);
                }
                t++;
            }

        }

        decideFromSing();
    }


    public void listenLoop()
    {


        while (listen && !notify)
        {
            
            animLock = false;
            listenLock = false;
            playAnimation(animlisten, true);
            
        }
        decideFromListen();
        
    }



    public void walkLogic()
    {
        if (walkCords[0] > walkCords[1])
        {
            if (walking)
            {


                    if (frame.Location.X <= walkCords[1])
                    {
                        animLock = true;
                        if (sing)
                        {
                            playAnimation(animStopTurnRightSinging, true);
                        }
                        else
                        {
                            playAnimation(animStopTurnRightIdling, true);
                        }
                        walking = false;
                        walk = false;
                    }
                    else
                    {
                        if (sing)
                        {
                            playAnimationMoveFrame(animWalkRightSinging, true, 10);
                        }
                        else
                        {
                            playAnimationMoveFrame(animWalkRightIdling, true, 10);
                        }
                    }
                
            }
            else
            {
                if (sing)
                {
                    playAnimation(animTurnRightSinging, true);
                }
                else
                {
                    playAnimation(animTurnRightIdling, true);
                }
                walking = true;
            }


        }
        else
        {
            if (walking)
            {

                if (frame.Location.X >= walkCords[1])
                {
                    animLock = true;
                    if (sing)
                    {
                        playAnimation(animStopTurnLeftSinging, true);
                    }
                    else
                    {
                        playAnimation(animStopTurnLeftIdling, true);
                    }
                    walking = false;
                    walk = false;
                }
                else
                {

                    if (sing)
                    {
                        playAnimationMoveFrame(animWalkLeftSinging, true, 10);
                    }
                    else
                    {
                        playAnimationMoveFrame(animWalkLeftIdling, true, 10);
                    }
                }

            }
            else
            {
                if (sing)
                {
                    playAnimation(animTurnLeftSinging, true);
                }
                else
                {
                    playAnimation(animTurnLeftIdling, true);
                }
                walking = true;
            }
        }
    }
       
}

