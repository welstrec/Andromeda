using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using AGaugeApp;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Andromeda;

namespace MikuDash
{
    public partial class MikuDashMain : Form
    {
 
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll")]
    private static extern IntPtr GetDesktopWindow();
    [DllImport("user32.dll")]
    private static extern IntPtr GetShellWindow();
    [DllImport("user32.dll", SetLastError = true)]
    private static extern int GetWindowRect(IntPtr hwnd, out RECT rc);
    [DllImport("psapi.dll")]
    static extern int EmptyWorkingSet(IntPtr hwProc);




        private bool initializing = true;
        //Transparency

        private double Transparency = 1;
        public Boolean dinamyTransparency = false;
        private System.Windows.Forms.Timer mouseTransparencyThread;
        //
        public Boolean invalidateClick = false;
        public Animate mikuAnim;
        public Listener listener;
        private Thread listenThr;

        private Clock clk;
        private LogitechScreenApi logiDisp;
        private Thread clkThr;
        private Thread mailThr;
        public List<Bitmap> fall = new List<Bitmap>();





        private int offsetx;
        private int offsety;
        public static int VU_INCREASE_INTERVAL = 10;
        public static int VU_DECREASE_INTERVAL = 8;
        public MikuAnim soundAnimation = new MikuAnim();
        public DateSound soundDate;
        public MailModule mailModule;
        public List<MonitorInstance> monitInstances = new List<MonitorInstance>();




        public String notifyMessage;
        private int opac = 0;
        private int del1 = 0;
        private int del2 = 0;
        public SpeechRecognizer spr;
        
        private KeyboardHook kbH;
        private IntPtr desktopHandle; //Window handle for the desktop
        private IntPtr shellHandle; //Window handle for the shell
        private bool lazyDahsboard = false;
        

        public List<Bitmap> cpuUsgL = new List<Bitmap>();
        public List<Bitmap> cpuRamL = new List<Bitmap>();
        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

       

        public MikuDashMain()
        {
            this.Icon = Andromeda.Properties.Resources.basePrincipalForm;
            this.ShowIcon = true;
            try
            {
                logiDisp = new LogitechScreenApi();
            }
            catch(Exception e)
            {
                logiDisp = null;
            }            
            
            soundDate = new DateSound(this);
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();

            List<String> host = new List<String>();
         
            List<int> port = new List<int>();

            List<String> mail = new List<String>();
            
            List<String> pwd = new List<String>();
            
            mailModule = new MailModule(this,soundDate, host, port, mail, pwd);

            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(ScreenHandler);
            MinimizeFootprint();
            loadAnimations();
            soundAnimation.Visible = true;
            soundDate.Visible = true;
            enableClicks();
            showApps();
            CheckForIllegalCrossThreadCalls = false;
            kbH = new KeyboardHook(this);
            desktopHandle = GetDesktopWindow();
            shellHandle = GetShellWindow();

            
            
        }

        public void inhibitToFullScreen()
        {
            //Console.WriteLine("trg");
            if (!detectAppOnFullScreen())
            
            {
               
                //Console.WriteLine("nlz");
                if (lazyDahsboard)
                {
                    lazyDahsboard = false;
                    showApps();
                   
                }
            }
            else
            {
                //Console.WriteLine("lz");
                if (!lazyDahsboard)
                {

                    lazyDahsboard = true;
                
                    try
                    {
                        listener.stopAnim();
                        soundAnimation.Hide();
                    }
                    catch (Exception ef)
                    {

                    }
                }
            }
        }

        static void MinimizeFootprint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }
        private void ScreenHandler(object sender, EventArgs e)
        {
            inhibitToFullScreen();
            

           
        }
        public void loadCoords()
        {
            try
            {
                StreamReader streamReader = new StreamReader("init.ini");
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                this.Top = Convert.ToInt32(text.Split(';')[0]);
                this.Left = Convert.ToInt32(text.Split(';')[1]);
                soundAnimation.Top = Convert.ToInt32(text.Split(';')[2]);
                soundAnimation.Left = Convert.ToInt32(text.Split(';')[3]);
                soundDate.Top = Convert.ToInt32(text.Split(';')[4]);                
                soundDate.Left = Convert.ToInt32(text.Split(';')[5]);
                Transparency = Convert.ToDouble(text.Split(';')[6]);
                dinamyTransparency = Convert.ToBoolean(text.Split(';')[7]);
                foreach (MonitorInstance mi in monitInstances)
                {
                    mi.loadPosition();
                }
            }
            catch (Exception e)
            {
                Rectangle resolution = Screen.PrimaryScreen.Bounds;
                this.Top = 0;
                this.Left = (resolution.Width / 2) - (this.Width / 2);
                dinamyTransparency = false;
            }
        }
        public void saveCoords(){
            string[] lines = { this.Top + ";" + this.Left + ";" + soundAnimation.Top + ";" + soundAnimation.Left + ";" + soundDate.Top + ";" + soundDate.Left + ";" + Transparency + ";" + dinamyTransparency};

        File.WriteAllLines(@"init.ini", lines);
        foreach (MonitorInstance mi in monitInstances)
        {
            mi.savePosition();
        }
        
        }
        
        public void close()
        {
            terminateThreads();
       
            soundDate.Dispose();
            soundAnimation.Dispose();
            if (logiDisp != null)
            {
                logiDisp.disconect();
            }
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Dispose();
            }
            this.Dispose();            
        }

        public void terminateThreads()
        {

            terminateAnimationAndListenThread();

            if(clk != null) {
                clk.runLoop = false;
                if (clkThr != null)
                {
                    clkThr.Abort();
                }
            }



            if (mailModule!= null)
            {
                mailModule.mailActive = false;
                if (mailThr != null)
                {
                    mailThr.Abort();
                }
            }
            
        }
        public void updateMail(String num, Boolean newone, Boolean notify, String info)
        {
            mailLbl.Text = "" + num;
            if (newone)
            {
                mailLbl.ForeColor = Color.Orange;
                if (notify)
                {
                    listener.mikuAnim.notify = true;
                    notifyMessage = info;
                }
            }
            else
            {
                mailLbl.ForeColor = Color.White;
            }
        }

        public void startAnimationAndListenThread()
        {
            spr = new SpeechRecognizer();

            listener = new Listener(this,mikuAnim, spr, soundDate);
            mikuAnim.lstnr = listener;
            
            mikuAnim.sleep = true;
            listenThr = new Thread(new ThreadStart(listener.listen));
            listenThr.Start();

            mouseTransparencyThread = new System.Windows.Forms.Timer();
            mouseTransparencyThread.Tick += new EventHandler(mouseTransparencyMethod);
            mouseTransparencyThread.Interval = 300;
            mouseTransparencyThread.Start();

        }
        private void mouseTransparencyMethod(object sender, EventArgs e)
        {

            if (dinamyTransparency)
            {
                Point MousePositionPrincipal = this.PointToClient(Cursor.Position);
                int principalX = MousePositionPrincipal.X;
                int principalY = MousePositionPrincipal.Y;
                Point sAPosition = soundAnimation.PointToClient(Cursor.Position);
                int sAx = sAPosition.X;
                int sAy = sAPosition.Y;
                Point SDosition = soundDate.PointToClient(Cursor.Position);
                bool enableMonitorTransparency = true;
                int SDx = SDosition.X;
                int SDy = SDosition.Y;
                if (((principalX > 0) && (principalX < this.Width)) && ((principalY > 0) && (principalY < this.Height)))
                {
                    this.Opacity = Transparency;
                    enableMonitorTransparency = false;
                }
                if (((principalX < 0)|| (principalX >this.Width)) ||((principalY < 0)|| (principalY > this.Height)))
                {
                    this.Opacity = 1;
                }
                
                if (((sAx > 0) && (sAx < soundAnimation.Width)) && ((sAy > 0) && (sAy < soundAnimation.Height)))
                {
                    soundAnimation.Opacity = Transparency;
                    enableMonitorTransparency = false;
                }
                if (((sAx < 0) || (sAx > soundAnimation.Width)) || ((sAy < 0) || (sAy > soundAnimation.Height)))
                {
                    soundAnimation.Opacity = 1;
                }
                if (((SDx > 0) && (SDx < soundDate.Width)) && ((SDy > 0) && (SDy < soundDate.Height)))
                {
                    soundDate.Opacity = Transparency;
                    enableMonitorTransparency = false;
                }
                if (((SDx < 0) || (SDx > soundDate.Width)) || ((SDy < 0) || (SDy > soundDate.Height)))
                {
                    soundDate.Opacity = 1;
                }
                if(enableMonitorTransparency)
                {
                    int yMonitor;
                    int xMonitor;
                    Point MonitorPos;
                    
                    foreach (MonitorInstance mi in monitInstances)
                    {
                        MonitorPos = mi.PointToClient(Cursor.Position);
                        yMonitor = MonitorPos.Y;
                        xMonitor = MonitorPos.X;
                        if (((xMonitor > 0) && (xMonitor < mi.Width)) && ((yMonitor > 0) && (yMonitor < mi.Height)))
                        {
                            mi.Opacity = Transparency;
                        }
                        else
                        {
                            mi.Opacity = 1;
                        }
                    }
                }
            }
        }
        public void terminateAnimationAndListenThread()
        {
            if (listener != null)
            {
                listener.stopAnim();
                listener.tListen = false;
                if (listenThr != null)
                {
                    listenThr.Abort();
                }
            }
        }

        public void startThreads()
        {
            startAnimationAndListenThread();

            clk.runLoop = true;
            clkThr = new Thread(new ThreadStart(clk.getTime));
            clkThr.Start();
            mailModule.mailActive = true;
            mailThr = new Thread(new ThreadStart(mailModule.actualizarMensajesSinLeer));
            mailThr.Start();
        }

        public void loadAnimations()
        {
            try
            {
                List<Bitmap> animSleep = new List<Bitmap>();

                List<List<FileInfo>> animSing = new List<List<FileInfo>> ();
                List<List<FileInfo>> animIdle = new List<List<FileInfo>> ();
                List<List<FileInfo>> animlisten = new List<List<FileInfo>> ();
                List<List<FileInfo>> animSleepToIdle = new List<List<FileInfo>> ();
                List<List<FileInfo>> animIdleToSing = new List<List<FileInfo>> ();
                List<List<FileInfo>> animIdleToListen = new List<List<FileInfo>> ();
                List<List<FileInfo>> animDoCommand = new List<List<FileInfo>> ();
                List<List<FileInfo>> animListenToIdle = new List<List<FileInfo>> ();
                List<List<FileInfo>> animSingToIdle = new List<List<FileInfo>> ();
                List<List<FileInfo>> animIdleToSleep = new List<List<FileInfo>> ();
                List<List<FileInfo>> animWelcome = new List<List<FileInfo>>();

      List<List<FileInfo>> animTurnLeftSinging = new List<List<FileInfo>> ();
      List<List<FileInfo>> animTurnRightSinging = new List<List<FileInfo>> ();
      List<List<FileInfo>> animWalkLeftSinging = new List<List<FileInfo>> ();
      List<List<FileInfo>> animWalkRightSinging = new List<List<FileInfo>> ();
      List<List<FileInfo>> animStopTurnLeftSinging = new List<List<FileInfo>> ();
      List<List<FileInfo>> animStopTurnRightSinging = new List<List<FileInfo>> ();

      List<List<FileInfo>> animTurnLeftIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animTurnRightIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animWalkLeftIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animWalkRightIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animStopTurnLeftIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animStopTurnRightIdling = new List<List<FileInfo>> ();
      List<List<FileInfo>> animNotify = new List<List<FileInfo>>();

                List<Bitmap> dates = new List<Bitmap>();
                fall = new List<Bitmap>();
                //mage bck = Image.FromFile(@"miku/bck.png");



                //On memory uncompressed Resources Load

                
                if(detectarTamAnimacion())
                {
                    
                    loadUncompressedAnimations(animSleep, new DirectoryInfo("andromeda/sleep"), 1024, 768);
                    loadUncompressedAnimations(dates, new DirectoryInfo("./dates"), 70, 83);
                    loadUncompressedAnimations(cpuUsgL, new DirectoryInfo("./cpugau/usage"), 352, 15);
                    loadUncompressedAnimations(cpuRamL, new DirectoryInfo("./cpugau/ram"), 348, 10);
                    


                    //compressed Resources Load
                    
                    loadAnimations(animSing, new DirectoryInfo("andromeda/sing"));
                    loadAnimations(animIdle, new DirectoryInfo("andromeda/idle"));
                    loadAnimations(animlisten, new DirectoryInfo("andromeda/listen"));
                    loadAnimations(animSleepToIdle, new DirectoryInfo("andromeda/sleepidle"));
                    loadAnimations(animIdleToSing, new DirectoryInfo("andromeda/idlesing"));
                    loadAnimations(animIdleToListen, new DirectoryInfo("andromeda/idlelisten"));
                    loadAnimations(animDoCommand, new DirectoryInfo("andromeda/command"));
                    loadAnimations(animListenToIdle, new DirectoryInfo("andromeda/listenidle"));
                    loadAnimations(animSingToIdle, new DirectoryInfo("andromeda/singidle"));
                    loadAnimations(animIdleToSleep, new DirectoryInfo("andromeda/idlesleep"));
                    loadAnimations(animWelcome, new DirectoryInfo("andromeda/welcome"));

                    loadAnimations(animTurnLeftSinging, new DirectoryInfo("andromeda/animTurnLeftSinging"));
                    loadAnimations(animTurnRightSinging, new DirectoryInfo("andromeda/animTurnRightSinging"));
                    loadAnimations(animWalkLeftSinging, new DirectoryInfo("andromeda/animWalkLeftSinging"));
                    loadAnimations(animWalkRightSinging, new DirectoryInfo("andromeda/animWalkRightSinging"));
                    loadAnimations(animStopTurnLeftSinging, new DirectoryInfo("andromeda/animStopTurnLeftSinging"));
                    loadAnimations(animStopTurnRightSinging, new DirectoryInfo("andromeda/animStopTurnRightSinging"));

                    loadAnimations(animTurnLeftIdling, new DirectoryInfo("andromeda/animTurnLeftIdling"));
                    loadAnimations(animTurnRightIdling, new DirectoryInfo("andromeda/animTurnRightIdling"));
                    loadAnimations(animWalkLeftIdling, new DirectoryInfo("andromeda/animWalkLeftIdling"));
                    loadAnimations(animWalkRightIdling, new DirectoryInfo("andromeda/animWalkRightIdling"));
                    loadAnimations(animStopTurnLeftIdling, new DirectoryInfo("andromeda/animStopTurnLeftIdling"));
                    loadAnimations(animStopTurnRightIdling, new DirectoryInfo("andromeda/animStopTurnRightIdling"));
                    loadAnimations(animNotify, new DirectoryInfo("andromeda/notify"));
                }
                else
                {

                    soundAnimation.cambiarA1080();
                    loadUncompressedAnimations(animSleep, new DirectoryInfo("andromeda/sleep2"), 480, 360);
                    loadUncompressedAnimations(dates, new DirectoryInfo("./dates"), 70, 83);
                    loadUncompressedAnimations(cpuUsgL, new DirectoryInfo("./cpugau/usage"), 375, 11);
                    loadUncompressedAnimations(cpuRamL, new DirectoryInfo("./cpugau/ram"), 322, 7);
 
                    //compressed Resources Load
                    loadAnimations(animSing, new DirectoryInfo("andromeda/sing2"));
                    loadAnimations(animIdle, new DirectoryInfo("andromeda/idle2"));
                    loadAnimations(animlisten, new DirectoryInfo("andromeda/listen2"));
                    loadAnimations(animSleepToIdle, new DirectoryInfo("andromeda/sleepidle2"));
                    loadAnimations(animIdleToSing, new DirectoryInfo("andromeda/idlesing2"));
                    loadAnimations(animIdleToListen, new DirectoryInfo("andromeda/idlelisten2"));
                    loadAnimations(animDoCommand, new DirectoryInfo("andromeda/command2"));
                    loadAnimations(animListenToIdle, new DirectoryInfo("andromeda/listenidle2"));
                    loadAnimations(animSingToIdle, new DirectoryInfo("andromeda/singidle2"));
                    loadAnimations(animIdleToSleep, new DirectoryInfo("andromeda/idlesleep2"));
                    loadAnimations(animWelcome, new DirectoryInfo("andromeda/welcome2"));



                    loadAnimations(animTurnLeftSinging, new DirectoryInfo("andromeda/animTurnLeftSinging2"));
                    loadAnimations(animTurnRightSinging, new DirectoryInfo("andromeda/animTurnRightSinging2"));
                    loadAnimations(animWalkLeftSinging, new DirectoryInfo("andromeda/animWalkLeftSinging2"));
                    loadAnimations(animWalkRightSinging, new DirectoryInfo("andromeda/animWalkRightSinging2"));
                    loadAnimations(animStopTurnLeftSinging, new DirectoryInfo("andromeda/animStopTurnLeftSinging2"));
                    loadAnimations(animStopTurnRightSinging, new DirectoryInfo("andromeda/animStopTurnRightSinging2"));

                    loadAnimations(animTurnLeftIdling, new DirectoryInfo("andromeda/animTurnLeftIdling2"));
                    loadAnimations(animTurnRightIdling, new DirectoryInfo("andromeda/animTurnRightIdling2"));
                    loadAnimations(animWalkLeftIdling, new DirectoryInfo("andromeda/animWalkLeftIdling2"));
                    loadAnimations(animWalkRightIdling, new DirectoryInfo("andromeda/animWalkRightIdling2"));
                    loadAnimations(animStopTurnLeftIdling, new DirectoryInfo("andromeda/animStopTurnLeftIdling2"));
                    loadAnimations(animStopTurnRightIdling, new DirectoryInfo("andromeda/animStopTurnRightIdling2"));
                    loadAnimations(animNotify, new DirectoryInfo("andromeda/notify2"));
                }
                
                clk = new Clock(this,dates);
                
                mikuAnim = new Animate(soundAnimation,this, animSleep, animSing,  animIdle,    animlisten,    animSleepToIdle,    animIdleToSing,    animIdleToListen,    animDoCommand,    animListenToIdle,     animSingToIdle,     animIdleToSleep,animWelcome ,



           animTurnLeftSinging,
   animTurnRightSinging,
   animWalkLeftSinging,
   animWalkRightSinging,
   animStopTurnLeftSinging,
   animStopTurnRightSinging,

   animTurnLeftIdling,
   animTurnRightIdling,
   animWalkLeftIdling,
   animWalkRightIdling,
   animStopTurnLeftIdling,
   animStopTurnRightIdling,
   animNotify,
                    
                    
                    
                    listener,spr, new CommandImpl(this.Handle,this,listener,spr));

              
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        private void loadUncompressedAnimations(List<Bitmap> list, DirectoryInfo dir,int w,int h)
        {
            FileInfo[] files = dir.GetFiles();
            files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                MemoryStream stream = new MemoryStream();
                Image Dummy = Image.FromFile(file.FullName);

                Dummy.Save(stream, ImageFormat.Bmp);
                Bitmap bb = new Bitmap(w,h);

                using (Graphics g = Graphics.FromImage(bb))
                {

                    g.DrawImage(Dummy, 0, 0, w, h);
                }
                list.Add(bb);
                stream.Dispose();
            }
        }
        private void loadAnimations(List<List<FileInfo>> list, DirectoryInfo dir)
        {
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                List<FileInfo> filst = new List<FileInfo>();

                foreach (FileInfo fii in di.GetFiles())
                {
                    filst.Add(fii);
                }

                list.Add(filst);
            }
        }

        public void changeBox(Bitmap img)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool flag = false;
        public void setClock(String time,bool date,bool dot)
        {
            String[] spl = time.Split(';');
            if (date)
            {
                this.clockLbl.Text = spl[0] + "/" + spl[1];
                this.ampmLbl.Text = spl[2];
            }
            else
            {
                this.clockLbl.Text = spl[0] + (dot?":":" ") + spl[1];
                this.ampmLbl.Text = spl[2].Equals("a.m.") ? "AM" : "PM";
            }
        }
        public void setDate(Bitmap bm,String month,String yr,int dayweek)
        {
           soundDate.daysP.Image = bm;
           soundDate.Month.Text = month;
           soundDate.Year.Text = yr;

           switch (dayweek)
           {
               case 1:
                   soundDate.monLed.Visible = true;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = false;
                   break;

               case 2:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = true;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = false;
                   break;

               case 3:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = true;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = false;
                   break;

               case 4:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = true;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = false;
                   break;

               case 5:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = true;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = false;
                   break;

               case 6:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = true;
                   soundDate.sunLed.Visible = false;
                   break;

               case 7:
                   soundDate.monLed.Visible = false;
                   soundDate.tueLed.Visible = false;
                   soundDate.wedLed.Visible = false;
                   soundDate.thuLed.Visible = false;
                   soundDate.friLed.Visible = false;
                   soundDate.satLed.Visible = false;
                   soundDate.sunLed.Visible = true;
                   break;
           }
        }



        
        public void updateWindowMonitors(List<CUMonitorUpdate> monitorUpd)
        {
            
            if(monitInstances.Count != monitorUpd.Count){
                foreach(MonitorInstance mi in monitInstances){
                    mi.Dispose();
                }
                monitInstances.Clear();

                foreach(CUMonitorUpdate mu in monitorUpd){
                    MonitorInstance nm = new MonitorInstance(cpuUsgL,cpuRamL);
                    nm.refreshStats(mu,true);
                    if (initializing)
                    {
                        nm.loadPosition();
                        nm.Show();
                       
                    }

                    monitInstances.Add(nm);

                }
                initializing = false;
                

            }else{


            for(int i = 0;i < monitorUpd.Count;i++){
                monitInstances[i].refreshStats(monitorUpd[i],false);
            }


        }

        }
        public void setMonitor(List<CUMonitorUpdate> monitorUpd,int numProc,String netstat)
        {
            if (logiDisp != null)
            {
                logiDisp.updateMonitorLCD(monitorUpd);
            }
            updateWindowMonitors(monitorUpd);
            infoDisplay.Text = "Processes: " + numProc + "\n" + netstat;
            Application.DoEvents();
        }
        private void updateVU(AGauge vu, int newVal)
        {
            if (vu.Value  < newVal)
            {
                if (vu.Value < 101)
                {
                    vu.Value = newVal - vu.Value < VU_INCREASE_INTERVAL ? newVal : vu.Value + VU_INCREASE_INTERVAL;
                }
            }
            else
            {
                if (vu.Value > 0)
                {
                    vu.Value = vu.Value - newVal < VU_DECREASE_INTERVAL ? newVal : vu.Value - VU_DECREASE_INTERVAL;
                }
            }
        }


        private void mikuBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.Left = Cursor.Position.X - offsetx;
                this.Top = Cursor.Position.Y - offsety;
            }
        }

        private void mikuBox_MouseUp(object sender, MouseEventArgs e)
        {

            flag = false;
        }

        private void mikuBox_MouseDown(object sender, MouseEventArgs e)
        {
                offsetx = Cursor.Position.X - this.Location.X;
                offsety = Cursor.Position.Y - this.Location.Y;
                flag = true;
        }        
        private void mikuBox_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private int wllast;
        public void invalidateActions()
        {
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wllast = wl;
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
        }
        public void validateActions()
        {
            SetWindowLong(this.Handle, GWL.ExStyle, wllast);
        }
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            close();
        }
        public void enableClicks()
        {
            invalidateClick = true;
            invalidateActions();
            soundAnimation.invalidateActions();
            soundDate.invalidateActions();
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.invalidateActions();
            }
        }
        public void disableClicks()
        {
                      
            invalidateClick = false;
            validateActions();
            soundAnimation.validateActions();
            soundDate.validateActions();
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.validateActions();
            }

        }

        private void toolInvalid_Click(object sender, EventArgs e)
        {
           if (invalidateClick)
           {
            disableClicks();
           }
           else
           {
            enableClicks();
           }
        }

        private void toolPos_Click_1(object sender, EventArgs e)
        {
            saveCoords();
        }

        public void showApps()
        {
            loadCoords();
            terminateThreads();
            startThreads();
            fadeInAnim.Enabled = true;
        }

        public void hideApps()
        {
            this.Hide();
            soundDate.Hide();
            soundAnimation.Hide();
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Hide();
            }
        }


        private void toolShow_Click(object sender, EventArgs e)
        {
            showApps();
        }

        public void topmostApp()
        {
            
            if (this.Visible == true )
            {
                if (!lazyDahsboard)
                {
                    this.TopMost = true;
                    soundDate.TopMost = true;
                    soundAnimation.TopMost = true;
                    foreach (MonitorInstance mi in monitInstances)
                    {
                        mi.TopMost=true;
                    }
                }
                inhibitToFullScreen();

            }
        }

        private void toolHide_Click(object sender, EventArgs e)
        {
            hideApps();
        }
        private void fadeInAnim_Tick(object sender, EventArgs e)
        {
            if (opac == 0)
            {
                this.Opacity = 0;
                soundAnimation.Opacity = 0;
                soundDate.Opacity = 0;
                foreach (MonitorInstance mi in monitInstances)
                {
                    mi.Opacity = 0;
                    mi.Show();
                }
                this.Show();
                soundDate.Show();

                if (!lazyDahsboard)
                {
                    soundAnimation.Show();
                }
              
                opac++;
                
            }
            else if (opac == 200)
            {
                topmostApp();
                fadeInAnim.Enabled = false;
                opac = 0;
                del1 = 0;
                del2 = 0;
            }
            else
            {
                
                this.Opacity += 0.03;
                foreach (MonitorInstance mi in monitInstances)
                {
                    mi.Opacity+=0.03;
                }
                if (del1 > 50)
                {
                    soundAnimation.Opacity += 0.03;
                }
                if (del1 > 30)
                {
                    soundDate.Opacity += 0.03;
                }
                opac++;
                del1++;
                del2++;
            }
            if(!dinamyTransparency)
            {
                this.Opacity = Transparency;
                soundAnimation.Opacity = Transparency;
                soundDate.Opacity = Transparency;
                foreach (MonitorInstance mi in monitInstances)
                {
                    mi.Opacity = Transparency;
                }
            }

        }
        public void sprToggle()
        {
            if (spr.disableRecognizer)
            {
                
                spr.disableRecognizer = false;
                sprLedOn();
            }
            else
            {
                spr.disableRecognizer = true;
                spr.active = false;
                spr.cmdId = -1;
                sprLedOff();
            }
        }

        public void sprOn()
        {
           
            
                spr.disableRecognizer = false;
                sprLedOn();
            
        }

        public void sprOff()
        {


            spr.disableRecognizer = true;
            sprLedOff();
            

        }
        private void MikuDashMain_Load(object sender, EventArgs e)
        {

        }

        private void toggleRecognizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sprToggle();
        }
        
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new CalendarFrm().Show();
        }

        private void clockLbl_Click(object sender, EventArgs e)
        {

        }
        private bool detectarTamAnimacion()
        {
            bool es4K = false;
            IntPtr hWnd= GetForegroundWindow();
            Rectangle screenBounds = Screen.FromHandle(hWnd).Bounds;
            if ((screenBounds.Width > 1920) && (screenBounds.Height>1080))
            {
                es4K = true;
            }
            return es4K;
        }
        public bool detectAppOnFullScreen()
        {
             
    //Get the handles for the desktop and shell now.
   
            //Detect if the current app is running in full screen
            bool runningFullScreen = false;
            RECT appBounds;
            Rectangle screenBounds;
            IntPtr hWnd;

            //get the dimensions of the active window
            hWnd = GetForegroundWindow();
            if (hWnd != null && !hWnd.Equals(IntPtr.Zero))
            {
                //Check we haven't picked up the desktop or the shell
                if (!(hWnd.Equals(desktopHandle) || hWnd.Equals(shellHandle)))
                {
                    GetWindowRect(hWnd, out appBounds);
                    //determine if window is fullscreen
                    screenBounds = Screen.FromHandle(hWnd).Bounds;
                    Console.WriteLine("w-"+screenBounds.Width+" h-"+screenBounds.Height);
                    Console.WriteLine("w-" + (appBounds.Right - appBounds.Left) + " h-" + (appBounds.Bottom - appBounds.Top));
                    if ((appBounds.Bottom - appBounds.Top) >= screenBounds.Height && (appBounds.Right - appBounds.Left) >= screenBounds.Width)
                    {
                        Console.WriteLine("FS");
                        runningFullScreen = true;
                    }
                }
            }

            return runningFullScreen;
        }

        private void ampmLbl_Click(object sender, EventArgs e)
        {

        }

        private void viewMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VentanaLoginCorreo(this).Visible = true;
        }
        public void saveMailSettings(ListBox mailLists)
        {
            String[] lst;
            lst = new String[mailLists.Items.Count];
            int i = 0;
            foreach (String itm in mailLists.Items)
            {
                lst[i] = itm;
                i++;
            }
            File.WriteAllLines(@"mail.ini", lst);
        }

        public void loadMailSettings(ListBox mailLists,List<String> host, List<int> port , List<String> mail,List<String> pwd)
        {


            try
            {
                string[] lines = File.ReadAllLines(@"mail.ini");
                if (mailLists == null)
                {
                    host.Clear();
                    port.Clear();
                    mail.Clear();
                    pwd.Clear();
                }
                foreach (string line in lines)
                {
                    if (mailLists != null)
                    {
                        mailLists.Items.Add(line);
                    }
                    else
                    {
                        String[] acc = line.Split(';');
                        host.Add(acc[0]);
                        port.Add(Convert.ToInt32(acc[1]));
                        mail.Add(acc[2]);
                        pwd.Add(acc[3]);
                    }
                }
            }catch(Exception e){

            }

           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Transparency = 0.2;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Opacity = Transparency;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Transparency = 0.4;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Opacity = Transparency;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Transparency = 0.6;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Opacity = Transparency;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Transparency = 0.8;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Opacity = Transparency;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Transparency = 0.5;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {
                mi.Opacity = Transparency;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Transparency = 0.7;
            this.Opacity = Transparency;
            soundAnimation.Opacity = Transparency;
            soundDate.Opacity = Transparency;
            foreach (MonitorInstance mi in monitInstances)
            {                
                mi.Opacity = Transparency;
            }
        }
        public void listenLedBlink()
        {
            if (!listenerBlinker.Enabled)
            {
                listenerBlinker.Enabled = true;

            }

        }
        public void listenerLedOff()
        {
            listenerBlinker.Enabled = false;
            listenLedImg.Visible = false;

        }

        public void listenerLedOn()
        {
            listenerBlinker.Enabled = false;
            listenLedImg.Visible = true;


        }
        public void sprLedOn()
        {

            sprLedImg.Visible = true;
        }
        public void sprLedOff()
        {
            sprLedImg.Visible = false;
        }
        private void listenerBlinker_Tick(object sender, EventArgs e)
        {
            if (listenLedImg.Visible)
            {
                listenLedImg.Visible = false;
            }
            else
            {
                listenLedImg.Visible = true;
            }
        }

        private void dynamicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dinamyTransparency==false)
            {
                dinamyTransparency = true;
            }
            else
            {
                dinamyTransparency = false;
            }
        }
    }
}
