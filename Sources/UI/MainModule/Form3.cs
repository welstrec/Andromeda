using System;
using System.Drawing;
using System.Windows.Forms;
using AGaugeApp;
using System.Runtime.InteropServices;

namespace MikuDash
{
    public partial class DateSound : Form
    {
        public static int VU_INCREASE_INTERVAL = 8;
        public static int VU_DECREASE_INTERVAL = 6;
        public static int SPK_ACT = 1;
        bool flag = false;
        private int offsetx;
        private int offsety;
        private MikuDashMain mdm;
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

        private Boolean hide = false;
        private Boolean hideOnFullScreen = false;

        public Boolean getHidePerm()
        {
            return hide;
        }

        public Boolean getHideOnFullScreen()
        {
            return hideOnFullScreen;
        }


        public void setHidePerm(Boolean val)
        {
            hide = val;
        }

        public void setHideOnFullScreen(Boolean val)
        {
            hideOnFullScreen = val;
        }

        public DateSound(MikuDashMain mn)
        {
            mdm = mn;
            InitializeComponent();
        }
        public void setLevel(int valL,int lc, int l, int r, int c, int sl, int sr, int rl, int rr, int sw)
        {
            if (ldg.Visible)
            {
                ldg.Visible = false;
            }

            if (lc == 1)
            {
                updateVU(ch1Lv, -1, "", ch1L);
                updateVU(ch2Lv, -1, "", ch2L);
                updateVU(ch3Lv, -1, "", ch3L);
                updateVU(ch4Lv, c, "C", ch4L);
                updateVU(ch5Lv, -1, "", ch5L);
                updateVU(ch6Lv, -1, "", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);

                adit.Visible = true;
                adit.Text = "Mono\n\n1.0";
            }
            else if (lc == 2)
            {
                updateVU(ch1Lv, -1, "", ch1L);
                updateVU(ch2Lv, -1, "", ch2L);
                updateVU(ch3Lv, -1, "", ch3L);
                updateVU(ch4Lv, l, "L", ch4L);
                updateVU(ch5Lv, r, "R", ch5L);
                updateVU(ch6Lv, -1, "", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = true;
                adit.Text = "Stereo\n\n2.0";

               
            }
            else if (lc == 3)
            {
                updateVU(ch1Lv, -1, "", ch1L);
                updateVU(ch2Lv, -1, "", ch2L);
                updateVU(ch3Lv, l, "L", ch3L);
                updateVU(ch4Lv, c, "C", ch4L);
                updateVU(ch5Lv, r, "R", ch5L);
                updateVU(ch6Lv, -1, "", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = true;
                adit.Text = "Stereo\n\nCenter\n\n3.0";
            }
            else if (lc == 4)
            {
                updateVU(ch1Lv, l, "L", ch1L);
                updateVU(ch2Lv, r, "R", ch2L);
                updateVU(ch3Lv, sl, "SL", ch3L);
                updateVU(ch4Lv, sr, "SR", ch4L);
                updateVU(ch5Lv, -1, "", ch5L);
                updateVU(ch6Lv, -1, "", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = true;
                adit.Text = "Quad\n\nSurrnd\n\n4.0";

            }
            else if (lc == 5)
            {
                updateVU(ch1Lv, l, "L", ch1L);
                updateVU(ch2Lv, c, "C", ch2L);
                updateVU(ch3Lv, r, "R", ch3L);
                updateVU(ch4Lv, sl, "SL", ch4L);
                updateVU(ch5Lv, sr, "SR", ch5L);
                updateVU(ch6Lv, -1, "", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = true;
                adit.Text = "Surrnd\n\n5.0";
            }
            else if (lc == 6)
            {
                updateVU(ch1Lv, l, "L", ch1L);
                updateVU(ch2Lv, c, "C", ch2L);
                updateVU(ch3Lv, r, "R", ch3L);
                updateVU(ch4Lv, sw, "SW", ch4L);
                updateVU(ch5Lv, sl, "SL", ch5L);
                updateVU(ch6Lv, sr, "SR", ch6L);
                updateVU(ch7Lv, -1, "", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = true;
                adit.Text = "Surrnd\n\nLFE\n\n5.1";

   
            }
            else if (lc == 7)
            {
                updateVU(ch1Lv, l, "L", ch1L);
                updateVU(ch2Lv, c, "C", ch2L);
                updateVU(ch3Lv, r, "R", ch3L);
                updateVU(ch4Lv, sl, "SL", ch4L);
                updateVU(ch5Lv, sr, "SR", ch5L);
                updateVU(ch6Lv, rl, "RL", ch6L);
                updateVU(ch7Lv, rr, "RR", ch7L);
                updateVU(ch8Lv, -1, "", ch8L);
                adit.Visible = false;
                adit.Text = "Surrnd\n\n7.0";


            }
            else if (lc == 8)
            {
                updateVU(ch1Lv, l, "L", ch1L);
                updateVU(ch2Lv, c, "C", ch2L);
                updateVU(ch3Lv, r, "R", ch3L);
                updateVU(ch4Lv, sl, "SL", ch4L);
                updateVU(ch5Lv, sr, "SR", ch5L);
                updateVU(ch6Lv, rl, "RL", ch6L);
                updateVU(ch7Lv, rr, "RR", ch7L);
                updateVU(ch8Lv, sw, "SW", ch8L);
                adit.Visible = false;
                adit.Text = "Surrnd\n\nLFE\n\n7.1";


            }

            

        }

        /**/

        public void updateVU(Label vu, int newVal, String chname, Label ch)
        {

            if (newVal == -1)
            {
                vu.Visible = false;
                ch.Visible = false;
                vu.Text = "";
            }
            else
            {
                
                if (newVal == 0)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.DarkGray;
                    vu.ForeColor = Color.DarkGray;
                }
                else if (newVal <= 20)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.White;
                    vu.ForeColor = Color.White;
                }
                else if (newVal <= 40)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.White;
                    vu.ForeColor = Color.White;
                }
                else if (newVal <= 60)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.White;
                    vu.ForeColor = Color.White;
                }
                else if (newVal <= 80)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.White;
                    vu.ForeColor = Color.White;
                }
                else if (newVal <= 100)
                {
                    vu.Text = "";
                    ch.ForeColor = Color.White;
                    vu.ForeColor = Color.White;
                }
                if (!ch.Visible) { 
                vu.Visible = true;
                ch.Visible = true;
            }
            }
            
            ch.Text = chname;
            
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

        private void DateSound_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void vuR_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void listenerBlinker_Tick(object sender, EventArgs e)
        {

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lfeLbl_Click(object sender, EventArgs e)
        {

        }

        private void listenLedImg_Click(object sender, EventArgs e)
        {

        }

        private void sprLedImg_Click(object sender, EventArgs e)
        {

        }

        private void ch2Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch6Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch7Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch5Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch4Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch3Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch1Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch8Lv_Click(object sender, EventArgs e)
        {

        }

        private void ch8L_Click(object sender, EventArgs e)
        {

        }

        private void ch7L_Click(object sender, EventArgs e)
        {

        }

        private void ch6L_Click(object sender, EventArgs e)
        {

        }

        private void ch5L_Click(object sender, EventArgs e)
        {

        }

        private void ch4L_Click(object sender, EventArgs e)
        {

        }

        private void ch3L_Click(object sender, EventArgs e)
        {

        }

        private void ch2L_Click(object sender, EventArgs e)
        {

        }

        private void ch1L_Click(object sender, EventArgs e)
        {

        }

        private void hidPerm_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                hide = false;
                hidPerm.Checked = false;
            }
            else
            {
                hide = true;
                hidPerm.Checked = true;
            }
        }

        private void hidFull_Click(object sender, EventArgs e)
        {
            if (hideOnFullScreen)
            {
                hideOnFullScreen = false;
                hidFull.Checked = false;
            }
            else
            {
                hideOnFullScreen = true;
                hidFull.Checked = true;
            }
        }


    }
}
