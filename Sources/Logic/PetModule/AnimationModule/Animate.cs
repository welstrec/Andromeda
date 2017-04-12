using System;
using System.Collections.Generic;
using System.Drawing;
using MikuDash;
using System.IO;



public class Animate
{



    public static int ANIM_SPEED = 40;
    public static int MOV_SPEED = 15;
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
    private List<List<FileInfo>> animNotify;
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

    public Animate(MikuAnim frame, MikuDashMain framem,    List<Bitmap> animSleep,   List<List<FileInfo>> animSing,   List<List<FileInfo>> animIdle,   List<List<FileInfo>> animlisten,   List<List<FileInfo>> animSleepToIdle,   List<List<FileInfo>> animIdleToSing,   List<List<FileInfo>> animIdleToListen,   List<List<FileInfo>> animDoCommand,    List<List<FileInfo>> animListenToIdle,    List<List<FileInfo>> animSingToIdle,    List<List<FileInfo>> animIdleToSleep,List<List<FileInfo>> animWelcome, 
        
                
              List<List<FileInfo>> animTurnLeftSinging,
      List<List<FileInfo>> animTurnRightSinging,
      List<List<FileInfo>> animWalkLeftSinging,
      List<List<FileInfo>> animWalkRightSinging,
      List<List<FileInfo>> animStopTurnLeftSinging,
      List<List<FileInfo>> animStopTurnRightSinging,

      List<List<FileInfo>> animTurnLeftIdling,
      List<List<FileInfo>> animTurnRightIdling,
      List<List<FileInfo>> animWalkLeftIdling,
      List<List<FileInfo>> animWalkRightIdling,
      List<List<FileInfo>> animStopTurnLeftIdling,
      List<List<FileInfo>> animStopTurnRightIdling,
      List<List<FileInfo>> animNotify,
        
        Listener ls, SpeechRecognizer spr, CommandImpl cmdImpl)
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
        this.animNotify = animNotify;

            this.animTurnLeftSinging = animTurnLeftSinging;
    this.animTurnRightSinging = animTurnRightSinging;
    this.animWalkLeftSinging = animWalkLeftSinging;
    this.animWalkRightSinging = animWalkRightSinging;
    this.animStopTurnLeftSinging = animStopTurnLeftSinging;
    this.animStopTurnRightSinging = animStopTurnRightSinging;

    this.animTurnLeftIdling =animTurnLeftIdling;
    this.animTurnRightIdling =animTurnRightIdling;
    this.animWalkLeftIdling =animWalkLeftIdling;
    this.animWalkRightIdling = animWalkRightIdling;
    this.animStopTurnLeftIdling =animStopTurnLeftIdling;
    this.animStopTurnRightIdling =animStopTurnRightIdling;


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

    public Boolean playAnimationMoveFrame(List<List<FileInfo>> histo, Boolean switchAnim, int offset, double dest,Boolean normal)
    {
        if (switchAnim)
        {
            selectedDance = rndDance.Next(0, histo.Count);
        }
        else
        {
            selectedDance = 0;
        }
        if (normal)
        {

            for (int i = 0; i < histo[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(ANIM_SPEED - 10);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(histo[selectedDance][i].FullName) });
                frame.Left = frame.Location.X + offset;
            }
            return false;
        }
        else if ((frame.Left + (histo[selectedDance].Count * MOV_SPEED)) < dest && offset > 0)
        {

            for (int i = 0; i < histo[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(ANIM_SPEED - 20);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(histo[selectedDance][i].FullName) });
                frame.Left = frame.Location.X + offset;
            }
            return false;
        }
        else if ((frame.Left - (histo[selectedDance].Count * MOV_SPEED))  > dest && offset < 0)
        {

            for (int i = 0; i < histo[selectedDance].Count; i++)
            {
                System.Threading.Thread.Sleep(ANIM_SPEED - 20);
                frame.BeginInvoke(new changeBox(frame.changeBox), new Object[] { Image.FromFile(histo[selectedDance][i].FullName) });
                frame.Left = frame.Location.X + offset;
            }
            return false;
        }
        else
        {
            
            return true;
            
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

    public void decideFromNotify()
    {
        animLock = true;


        if (listen)
        {
            doIdleToListen();
        }
        else if (walk)
        {
            walkIdleLoop();
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

        if (walk)
        {
            walkSingLoop();
        }
        else if (sing && !listen && !notify)
        {
            singLoop();
        }
        else if (listen)
        {
            decideFromIdle();
        }
        else
        {
            doSingToIdle();
        }

    }

    public void decideFromWalkSing()
    {
        animLock = true;

        if (walk)
        {
            walkSingLoop();
        }
        else if (sing && !listen)
        {
            singLoop();
        }
        else if (listen)
        {
            decideFromListen();
        }
        else
        {
            doSingToIdle();
        }

    }

    public void decideFromWalkIdle()
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
        else if (walk)
        {
            walkIdleLoop();
        }
        else
        {
            idleLoop();
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
            decideFromIdle();
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
        else if (notify)
        {
            notifyLoop();
        }

        
        else if (walk)
        {
            walkIdleLoop();
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
        while ((!listen && !sing && !notify && !walk && to < 7))
        {
            animLock = false;

            playAnimation(animIdle, true);
            to++;
            
           

        }

        decideFromIdle();

    }

    public void sleepLoop()
    {
   
        frame.normalRegion();
        
        while (sleep && !listen && !sing && !notify && !walk)
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
        while (sing && !listen && !notify && !walk)
        {
            animLock = false;

            if(t ==danceDelay){
                danceDelay = 1;

                    playAnimation(animSing, true);
                
                t=0;
            }else{


                   playAnimation(animSing, false);
                
                t++;
            }

        }

        decideFromSing();
    }


    public void listenLoop()
    {


        while (listen)
        {
            
            animLock = false;
            listenLock = false;
            playAnimation(animlisten, true);
            
        }
        decideFromListen();
        
    }

    public void notifyLoop()
    {

        for (int i = 0; i < 20 && notify; i++)
        {
            animLock = false;
            listenLock = false;
            playAnimation(animNotify, true);
        }
        notify = false;
        decideFromNotify();

    }

    public void walkIdleLoop()
    {
        
        if (walkCords[0] < walkCords[1])
        {
            int thicks = moveCalculator(animTurnRightIdling, animWalkRightIdling, animStopTurnRightIdling, walkCords[1]);
            if (thicks > 0)
            {
                playAnimationMoveFrame(animTurnRightIdling, false, MOV_SPEED, 0, true);
                thicks--;
                while (thicks > 1)
                {
                    playAnimationMoveFrame(animWalkRightIdling, false, MOV_SPEED, 0, true);
                    thicks--;
                }
                playAnimationMoveFrame(animStopTurnRightIdling, false, MOV_SPEED, 0, true);
            }
        }
        else
        {
            int thicks = moveCalculator(animTurnLeftIdling, animWalkLeftIdling, animStopTurnLeftIdling, walkCords[1]);
            if (thicks > 0)
            {
                playAnimationMoveFrame(animTurnLeftIdling, false, -MOV_SPEED, 0, true);
                thicks--;
                while (thicks > 1)
                {
                    playAnimationMoveFrame(animWalkLeftIdling, false, -MOV_SPEED, 0, true);
                    thicks--;
                }
                playAnimationMoveFrame(animStopTurnLeftIdling, false, -MOV_SPEED, 0, true);
            }
        }
        walk = false;
        decideFromWalkIdle();
    }

    public int moveCalculator(List<List<FileInfo>> inw, List<List<FileInfo>> wl, List<List<FileInfo>>outw,double dest)
    {
        int inwc = 0;
        int wlc = 0;
        int outwc = 0;

        double rdistance = Math.Abs(dest - frame.Left);
        
        double fDistance = (inw[inwc].Count * MOV_SPEED) + (outw[outwc].Count * MOV_SPEED);

        Console.WriteLine("RD"+ rdistance+"-"+fDistance);
        int thicks = 2;
        if (fDistance <= rdistance)
        {
            while ((fDistance + wl[wlc].Count * MOV_SPEED) <= rdistance)
            {
                fDistance += (wl[wlc].Count * MOV_SPEED);
                thicks++;
            }
        }
        else
        {
            return 0;
        }

        return thicks;

    }

    public void walkSingLoop()
    {
        if (walkCords[0] < walkCords[1])
        {
            int thicks = moveCalculator(animTurnRightSinging, animWalkRightSinging, animStopTurnRightSinging, walkCords[1]);
            if (thicks > 0)
            {
                playAnimationMoveFrame(animTurnRightSinging, false, MOV_SPEED, 0, true);
                thicks--;
                while (thicks > 1)
                {
                    playAnimationMoveFrame(animWalkRightSinging, false, MOV_SPEED, 0, true);
                    thicks--;
                }
                playAnimationMoveFrame(animStopTurnRightSinging, false, MOV_SPEED, 0, true);
            }
            else
            {
                //Console.WriteLine("XC");
            }
        }
        else
        {
            int thicks = moveCalculator(animTurnLeftSinging, animWalkLeftSinging, animStopTurnLeftSinging, walkCords[1]);
            if (thicks > 0)
            {
                playAnimationMoveFrame(animTurnLeftSinging, false, -MOV_SPEED, 0, true);
                thicks--;
                while (thicks > 1)
                {
                    playAnimationMoveFrame(animWalkLeftSinging, false, -MOV_SPEED, 0, true);
                    thicks--;
                }
                playAnimationMoveFrame(animStopTurnLeftSinging, false, -MOV_SPEED, 0, true);
            }
            else
            {
                //Console.WriteLine("XC");
            }
        }
        walk = false;
        decideFromWalkSing();
    }
    
       
}

