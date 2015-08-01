using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AGaugeApp;

namespace MikuDash
{
    public partial class MikuAnim : Form
    {
        bool flag = false;
        private int offsetx;
        private int offsety;
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



        
        public MikuAnim()
        {
            InitializeComponent();
           
     
            normalRegion();
            CheckForIllegalCrossThreadCalls = false;
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
        public void normalRegion()
        {/*
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(this.Size.Width, 0, this.Size.Width , this.Size.Height);
            path.AddLine(this.Size.Width, this.Size.Height, 55, this.Size.Height);
            path.AddLine(55, this.Size.Height, 30, 143);
            path.AddLine(30, 143, 55, 65);
            path.AddLine(55, 65, 173, 65);
            path.AddLine(173, 65, 173, 48);
            path.AddLine(173, 48, 188, 48);
            path.AddLine(188, 48, 188, 0);
            path.AddLine(188, 0, this.Size.Width, 0);
            this.Region = new Region(path);
            /*
            path.AddLine(0, 0, 66, 0);
            path.AddLine(66, 0, 66, 95);
            path.AddLine(66, 95, 85, 95);
            path.AddLine(85, 95, 125, 18);
            //path.AddLine(58, 75, 58, 40);
            //path.AddLine(58, 40, 125, 10);
            path.AddLine(125, 18, 180, 18);
            path.AddLine(185, 18, 200, 80);
            path.AddLine(200, 80, this.Size.Width-30, 110);
            path.AddLine(this.Size.Width-30, 110, this.Size.Width - 40, 125);
            path.AddLine(this.Size.Width - 40, 125, this.Size.Width - 60, 125);
            path.AddLine(this.Size.Width - 60, 125, this.Size.Width - 60, this.Size.Height);

            path.AddLine(this.Size.Width - 60, this.Size.Height, 0, this.Size.Height);
            path.AddLine(0, this.Size.Height, 0, 0);
            this.Region = new Region(path);*/
        }
        public void startleRegion()
        {
        }

        public void changeBox(Bitmap img)
        {

            //mikuBox.Invalidate();
            AndromedaBox.Image = img;
            //mikuBox.Update(); 
        }
        public void cambiarA1080()
        {
            AndromedaBox.Width = 480;
            AndromedaBox.Height = 360;
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

        private void MikuAnim_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
