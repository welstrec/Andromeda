using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGaugeApp;
using System.Runtime.InteropServices;
using Andromeda;

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

        public void sprLedOn(){

            sprLedImg.Visible =true;
        }
        public void sprLedOff(){
            sprLedImg.Visible =false;
        }

       

        public DateSound(MikuDashMain mn)
        {
            mdm = mn;
            InitializeComponent();
        }
        public void setLevel(int valL,int valR, int l, int r, int c, int sl, int sr, int rl, int rr, int sw)
        {


            if (l >= SPK_ACT)
            {
                li.Visible = true;
            }
            else
            {
                li.Visible = false;
            }
            if (r >= SPK_ACT)
            {
                ri.Visible = true;
            }
            else
            {
                ri.Visible = false;
            }
            if (c >= SPK_ACT)
            {
                ci.Visible = true;
            }
            else
            {
                ci.Visible = false;
            }
            if (sl >= SPK_ACT)
            {
                sli.Visible = true;
            }
            else
            {
                sli.Visible = false;
            }
            if (sr >= SPK_ACT)
            {
                sri.Visible = true;
            }
            else
            {
                sri.Visible = false;
            }
            if (rl >= SPK_ACT)
            {
                rli.Visible = true;
            }
            else
            {
                rli.Visible = false;
            }
            if (rr >= SPK_ACT)
            {
                rri.Visible = true;
            }
            else
            {
                rri.Visible = false;
            }
            if (sw >= SPK_ACT)
            {
                swi.Visible = true;
            }
            else
            {
                swi.Visible = false;
            }

            //updateVU(vuL, valL);
            if (valR == 6)
            {
                lfeLbl.Text = "1";
                chLbl.Text = "5";
            }
            else if (valR == 8)
            {
                lfeLbl.Text = "1";
                chLbl.Text = "7";
            }
            else
            {
                chLbl.Text = ""+valR;
                lfeLbl.Text = "0";
            }

        }

        public void updateVU(AGauge vu, int newVal)
        {
            if (vu.Value < newVal)
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

        public void updateMail(String num,Boolean newone,Boolean notify,String info)
        {
            mailLbl.Text = ""+num;
            if (newone)
            {
                mailLbl.ForeColor = Color.Orange;
                if (notify)
                {
                    mdm.listener.mikuAnim.notify = true;
                    mdm.notifyMessage = info;
                    //mdm.playAlertMail();
                }
            }
            else
            {
                mailLbl.ForeColor = Color.LightGreen;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lfeLbl_Click(object sender, EventArgs e)
        {

        }


    }
}
