using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class MonitorInstance : Form
    {


        private int ALERT_RAM = 95;
        private int ALERT_TEMP = 79;


        private SoundPlayer alertMemory;
        private bool playingMemAlert = false;
        private SoundPlayer alertTemp;
        private bool playingTempAlert = false;
        public bool overrideAlert = false;
        private int offsetx;
        private int offsety;
        bool flag = false;
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


        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

        static readonly IntPtr HWND_TOP = new IntPtr(0);

        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

        const UInt32 SWP_NOSIZE = 0x0001;

        const UInt32 SWP_NOMOVE = 0x0002;

        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public List<Bitmap> cpuUsgL;
        public List<Bitmap> cpuRamL;


        public MonitorInstance(List<Bitmap> usg, List<Bitmap> ram)
        {
            InitializeComponent();
            invalidateActions();
            cpuUsgL = usg;
            cpuRamL = ram;
            
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
        public void refreshStats(CUMonitorUpdate upd, bool init)
        {
            if (init) { 
            monNameDsp.Text = upd.devName;
            this.Text = upd.devName+" "+upd.fullName +" Monitor";
            Console.WriteLine("tipo: "+ upd.getIconInfo());
            int type = upd.getIconInfo();
            if (type==1)
            {
                    this.Icon = Properties.Resources.gpuNvidia;
                    this.ShowIcon = true;
            }
            if(type==2)
            {
                    this.Icon = Properties.Resources.RadeonGPU;
                    this.ShowIcon = true;
            }
            if (type==3)
            {
                    this.Icon = Properties.Resources.inteli3;
                    this.ShowIcon = true;
            }
            if (type==4)
            {
                  this.Icon = Properties.Resources.inteli5;
                  this.ShowIcon = true;
            }
            if(type==5)
            {
                    this.Icon = Properties.Resources.inteli7;
                    this.ShowIcon = true;
            }
            if (type==6)
            {
                    this.Icon = Properties.Resources.amd;
                    this.ShowIcon = true;
            }
            if (upd.deviceType == CUMonitorUpdate.DEV_TYPE_GPU)
            {
                ALERT_RAM = Int32.MaxValue;
            }
            else
            {
                ALERT_RAM = 94;
            }
           
            ALERT_TEMP = upd.tjmax;
        }
          ldDsp.Text = "" + upd.load.ToString("D3");
           tempDsp.Text = "" + upd.temp.ToString("D3");
           ramDsp.Text = "" + upd.ramUsage.ToString("D3");
            clkDsp.Text = "" + upd.clk.ToString("D4");
            setGauge(ldGau, upd.load, cpuUsgL);
            setGauge(ramGau, upd.ramUsage, cpuRamL);
            if ((upd.ramUsage > ALERT_RAM) && !overrideAlert)
            {
                if (!playingMemAlert)
                {
                    playAlertMemory();
                    monNameDsp.ForeColor = Color.Red;
                }

            }
            else if (upd.ramUsage <= ALERT_RAM)
            {

                if (playingMemAlert)
                {
                    stopAlertMemory();
                    monNameDsp.ForeColor = Color.Black;
                }

            }


            if ((upd.temp > ALERT_TEMP) && !overrideAlert)
            {
                if (!playingTempAlert)
                {
                    playAlertTemp();
                    monNameDsp.ForeColor = Color.Red;
                }
            }
            else if (upd.temp <= ALERT_TEMP)
            {

                if (playingTempAlert)
                {
                    stopAlertTemp();
                    monNameDsp.ForeColor = Color.Black;

                }
            }



        }


        public void setGauge(PictureBox gau, int val, List<Bitmap> bmStr)
        {
            if (bmStr != null)
            {
                if (val <= 0)
                {
                    gau.BackgroundImage = bmStr[0];
                }
                else if (val <= 10)
                {
                    gau.BackgroundImage = bmStr[1];
                }
                else if (val <= 20)
                {
                    gau.BackgroundImage = bmStr[2];
                }
                else if (val <= 30)
                {
                    gau.BackgroundImage = bmStr[3];
                }
                else if (val <= 40)
                {
                    gau.BackgroundImage = bmStr[4];
                }
                else if (val <= 50)
                {
                    gau.BackgroundImage = bmStr[5];
                }
                else if (val <= 60)
                {
                    gau.BackgroundImage = bmStr[6];
                }
                else if (val <= 70)
                {
                    gau.BackgroundImage = bmStr[7];
                }
                else if (val <= 80)
                {
                    gau.BackgroundImage = bmStr[8];
                }
                else if (val <= 90)
                {
                    gau.BackgroundImage = bmStr[9];
                }
                else if (val <= 100)
                {
                    gau.BackgroundImage = bmStr[10];
                }
                else if (val > 100)
                {
                    gau.BackgroundImage = bmStr[10];
                }

            }
        }

        private void tempDsp_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.Left = Cursor.Position.X - offsetx;
                this.Top = Cursor.Position.Y - offsety;
            }
        }

        private void tempDsp_MouseDown(object sender, MouseEventArgs e)
        {
          
            
                offsetx = Cursor.Position.X - this.Location.X;
                offsety = Cursor.Position.Y - this.Location.Y;
                flag = true;
            
        }

        private void tempDsp_MouseUp(object sender, MouseEventArgs e)
        {

            flag = false;
        
        
        }

        private void MonitorInstance_VisibleChanged(object sender, EventArgs e)
        {


            
        }

        public void loadPosition()
        {
            try
            {
                StreamReader streamReader = new StreamReader(Text + ".ini");
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                this.Top = Convert.ToInt32(text.Split(';')[0]);
                this.Left = Convert.ToInt32(text.Split(';')[1]);



            }
            catch (Exception e)
            {
                Rectangle resolution = Screen.PrimaryScreen.Bounds;
                this.Top = 0;
                this.Left = (resolution.Width / 2) - (this.Width / 2);
                Console.WriteLine(e.ToString());
            }
            
        }
        public void savePosition()
        {
            string[] lines = { this.Top + ";" + this.Left };

            System.IO.File.WriteAllLines(@Text+".ini", lines);
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
        public void playAlertMail()
        {
            alertTemp = new SoundPlayer();
            alertTemp.SoundLocation = @"./sound/newmail.wav";
            alertTemp.LoadAsync();
            alertTemp.Play();

        }

    }
}
