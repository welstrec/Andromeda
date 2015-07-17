using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AGaugeApp;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Media;
using System.Diagnostics;


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





        private Boolean invalidateClick = false;
        private Animate mikuAnim;
        public Listener listener;
        private Thread listenThr;
        public static int ALERT_RAM = 95;
        public static int ALERT_TEMP = 79;
        private clock clk;
        private Thread clkThr;
        
        private int[] pixels = { 1024,768};



        public List<Bitmap> fall = new List<Bitmap>();

        public List<Bitmap> cpuUsgL = new List<Bitmap>();
        public List<Bitmap> cpuRamL = new List<Bitmap>();
        public List<Bitmap> gpuUsgL = new List<Bitmap>();
        public List<Bitmap> gpuRamL = new List<Bitmap>();



        private int offsetx;
        private int offsety;
        public static int VU_INCREASE_INTERVAL = 10;
        public static int VU_DECREASE_INTERVAL = 8;
        public MikuAnim soundAnimation = new MikuAnim();
        public DateSound  soundDate = new DateSound();

        private int opac = 0;
        private int del1 = 0;
        private int del2 = 0;
        public SpeechRecognizer spr;
        private SoundPlayer alertMemory ;
        private bool playingMemAlert = false;
        private SoundPlayer alertTemp;
        private bool playingTempAlert = false;
        private KeyboardHook kbH;
        private IntPtr desktopHandle; //Window handle for the desktop
        private IntPtr shellHandle; //Window handle for the shell
        private bool lazyDahsboard = false;
        public bool overrideAlert = false;
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
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(ScreenHandler);
            MinimizeFootprint();

            //mikuBox.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //mikuBox.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); 
            

            //startThreads();

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
            Console.WriteLine("trg");
            if (!detectAppOnFullScreen())
            
            {
               
                Console.WriteLine("nlz");
                if (lazyDahsboard)
                {
                    lazyDahsboard = false;
                    showApps();
                   
                }
            }
            else
            {
                Console.WriteLine("lz");
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

            }
            catch (Exception e)
            {
                Rectangle resolution = Screen.PrimaryScreen.Bounds;
                this.Top = 0;
                this.Left = (resolution.Width / 2) - (this.Width / 2);
                Console.WriteLine(e.ToString());
            }
        }
        public void saveCoords(){
            string[] lines = { this.Top + ";" + this.Left + ";" + soundAnimation.Top + ";" + soundAnimation.Left + ";" + soundDate.Top + ";" + soundDate.Left};
        
        System.IO.File.WriteAllLines(@"init.ini", lines);

        
        }
        
        public void close()
        {
            terminateThreads();
       
            soundDate.Dispose();
            soundAnimation.Dispose();
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
            
           

            
        }

        public void startAnimationAndListenThread()
        {
            spr = new SpeechRecognizer();

            listener = new Listener(mikuAnim, spr, soundDate);
            mikuAnim.lstnr = listener;
            mikuAnim.sleep = true;
            listenThr = new Thread(new ThreadStart(listener.listen));
            listenThr.Start();
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



                List<Bitmap> dates = new List<Bitmap>();
                fall = new List<Bitmap>();
                //mage bck = Image.FromFile(@"miku/bck.png");



                //On memory uncompressed Resources Load


                loadUncompressedAnimations(animSleep, new DirectoryInfo("andromeda/sleep"), pixels[0], pixels[1]);
                loadUncompressedAnimations(dates, new DirectoryInfo("./dates"),148, 145);
                loadUncompressedAnimations(fall, new DirectoryInfo("./fall"),64,64);
                loadUncompressedAnimations(cpuUsgL, new DirectoryInfo("./cpugau/usage"),375,11);
                loadUncompressedAnimations(cpuRamL, new DirectoryInfo("./cpugau/ram"),322,7);
                loadUncompressedAnimations(gpuUsgL, new DirectoryInfo("./gpugau/usage"), 375, 11);
                loadUncompressedAnimations(gpuRamL, new DirectoryInfo("./gpugau/ram"), 322, 7);
                

                //compressed Resources Load
               
                loadAnimations(animSing,new DirectoryInfo("andromeda/sing"));
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
             
                
                clk = new clock(this,dates);
                
                mikuAnim = new Animate(soundAnimation,this, animSleep, animSing,  animIdle,    animlisten,    animSleepToIdle,    animIdleToSing,    animIdleToListen,    animDoCommand,    animListenToIdle,     animSingToIdle,     animIdleToSleep,animWelcome ,listener,spr, new CommandImpl(this.Handle,this,listener,spr));
                //mikuBox.Image = (Bitmap)animSleep[10];
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
                //animTrans.Add(new Bitmap(file.FullName));


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
           
                //mikuBox.Invalidate();
                //mikuBox.Image = img;
                //mikuBox.Update(); 
                      
            

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
            //setLevel (Int32.Parse (spl[2]));
        }
        public void setDate(Bitmap bm,String month,String yr)
        {
           soundDate.daysP.Image = bm;
           soundDate.Month.Text = month.ToUpper();
           soundDate.Year.Text = yr;
        }

        public void setGauge(PictureBox gau, int val, List<Bitmap> bmStr)
        {
            if (val <= 0)
            {
                gau.Image = bmStr[0];
            }
            if (val <= 10)
            {
                gau.Image = bmStr[1];
            } else if (val <= 20)
            {
                gau.Image = bmStr[2];
            } else if (val <= 30)
            {
                gau.Image = bmStr[3];
            } else if (val <= 40)
            {
                gau.Image = bmStr[4];
            }
            else if (val <= 50)
            {
                gau.Image = bmStr[5];
            }
            else if (val <= 60)
            {
                gau.Image = bmStr[6];
            }
            else if (val <= 70)
            {
                gau.Image = bmStr[7];
            }
            else if (val <= 80)
            {
                gau.Image = bmStr[8];
            }
            else if (val <= 90)
            {
                gau.Image = bmStr[9];
            }
            else if (val <= 100)
            {
                gau.Image = bmStr[10];
            }
            else if (val > 100)
            {
                gau.Image = bmStr[10];
            }


        }

        public void setMonitor(int valCPU, int valRAM, int valCPUT, int valCPUF,int valGPU,int valVRam, int valGPUT,int valGPUF,int valGPUCLK, int valCPUCLK)
        {
            //vuAvg.Level = ((int)((valL + valR) / 2));
            setGauge(pictureCpuUsage,valCPU,cpuUsgL);
            setGauge(pictureGpuUsage, valGPU, gpuUsgL);
            setGauge(pictureCpuRam, valRAM, cpuRamL);
            setGauge(pictureGpuRam, valVRam, gpuRamL);
            //updateVU(vuRam, valRAM);
            //updateVU(vuCPU, valCPU);
            //updateVU(vuCPUT, valCPUT);
            cpuLbl.Text = valCPU.ToString("D3");
            gpuLbl.Text = valGPU.ToString("D3");
            ramLbl.Text = valRAM.ToString("D3");
            vramLbl.Text = valVRam.ToString("D3");
            cpuTempLbl.Text = valCPUT.ToString("D3");
            cpuFan.Text = valCPUF.ToString("D4");
            

            //updateVU(vuGPU, valGPU);
            gpuTempLbl.Text = valGPUT.ToString("D3");
            //updateVU(vuVRam, valVRam);
            gpuFan.Text = valGPUF.ToString("D4");
            //updateVU(vuGPUT, valGPUT);
            gpuCLK.Text = valGPUCLK.ToString("D4");
            cpuCLK.Text = valCPUCLK.ToString("D4");

            if (valRAM > ALERT_RAM)
            {
                ramLbl.ForeColor = Color.Orange;
            }
            else
            {
                ramLbl.ForeColor = Color.White;
            }
            if (valVRam > ALERT_RAM)
            {
                vramLbl.ForeColor = Color.Orange;
            }
            else
            {
                vramLbl.ForeColor = Color.White;
            }


            if ((valRAM > ALERT_RAM) && !overrideAlert)
            {
                if (!playingMemAlert)
                {
                    playAlertMemory();
                    
                }
               
            }
            else if (valRAM <= ALERT_RAM) 
            {
                
                if (playingMemAlert)
                {
                    stopAlertMemory();
                   
                }
                                
            }


            if ((valCPUT > ALERT_TEMP || valGPUT > ALERT_TEMP) && !overrideAlert)
            {
                if (!playingTempAlert)
                {
                    playAlertTemp();
                }
            }
            else if (valCPUT <= ALERT_TEMP && valGPUT <= ALERT_TEMP)
            {
                
                if (playingTempAlert)
                {
                    stopAlertTemp();
                    
                }
            }


            if (valCPUT <= ALERT_TEMP && valGPUT <= ALERT_TEMP && valRAM <= ALERT_RAM && valVRam <= ALERT_RAM)
            {
                overrideAlert = false;
            }

            int prom = (valCPU + valGPU) / 2;
            
            if(prom < 20){
                falloutStat.Image = fall[0];
            }else if(prom < 40){
                falloutStat.Image = fall[1];
            }else if(prom < 60){
                falloutStat.Image = fall[2];
            }else if(prom < 80){
                falloutStat.Image = fall[3];
            }else {
                falloutStat.Image = fall[4];
            }

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
        }
        public void disableClicks()
        {
                      
            invalidateClick = false;
            validateActions();
            soundAnimation.validateActions();
            soundDate.validateActions();
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
                }
                inhibitToFullScreen();

            }
        }

        private void toolHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            soundDate.Hide();
            soundAnimation.Hide();
        }

       

        private void fadeInAnim_Tick(object sender, EventArgs e)
        {
            if (opac == 0)
            {
                this.Opacity = 0;
                soundAnimation.Opacity = 0;
                soundDate.Opacity = 0;
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
                //System.Threading.Thread.Sleep(50);
                this.Opacity += 0.03;

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
                //Application.DoEvents();
            }
            
                       
        }
        public void sprToggle()
        {
            if (spr.disableRecognizer)
            {
                
                spr.disableRecognizer = false;
                soundDate.sprLedOn();
            }
            else
            {
                spr.disableRecognizer = true;
                spr.active = false;
                spr.cmdId = -1;
                soundDate.sprLedOff();
            }
        }

        public void sprOn()
        {
           
            
                spr.disableRecognizer = false;
                soundDate.sprLedOn();
            
        }

        public void sprOff()
        {


            spr.disableRecognizer = true;
            soundDate.sprLedOff();
            

        }
        private void MikuDashMain_Load(object sender, EventArgs e)
        {

        }

        private void toggleRecognizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sprToggle();
        }
        private void playAlertMemory()
        {
            if (!playingTempAlert)
            {
                alertMemory = new SoundPlayer();
                alertMemory.SoundLocation = "./sound/memAlert.wav";
                alertMemory.LoadAsync();
                alertMemory.PlayLooping();
                playingMemAlert = true;
            }
        }
        public void stopAlertMemory()
        {
            if (alertMemory != null)
            {
                if (!playingTempAlert)
                {
                    alertMemory.Stop();
                    playingMemAlert = false;
                }
            }
        }
        public void stopAlertTemp()
        {
            if (alertTemp != null)
            {
                alertTemp.Stop();
                playingTempAlert = false;
            }
        }
        private void playAlertTemp()
        {
            alertTemp = new SoundPlayer();
            alertTemp.SoundLocation = @"./sound/tempAlert.wav";
            alertTemp.LoadAsync();
            alertTemp.PlayLooping();
            playingTempAlert = true;
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new CalendarFrm().Show();
        }

        private void clockLbl_Click(object sender, EventArgs e)
        {

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
    }
}
