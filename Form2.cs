using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

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
            if(detectarTamAnimacion())
            {
                this.Size= new Size(1024, 768);
                this.AndromedaBox.Size = new Size(1024,768);
            }
            else
            {
                this.Size = new Size(420, 400);
                this.AndromedaBox.Size= new Size(420, 400); 
            }
            normalRegion();
            CheckForIllegalCrossThreadCalls = false;
        }
        private bool detectarTamAnimacion()
        {
            bool es4K = false;
            IntPtr hWnd = GetForegroundWindow();
            Rectangle screenBounds = Screen.FromHandle(hWnd).Bounds;
            if ((screenBounds.Width > 1920) && (screenBounds.Height > 1080))
            {
                es4K = true;
            }
            return es4K;
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
        {
        }
        public void startleRegion()
        {
        }

        public void changeBox(Bitmap img)
        {           
            AndromedaBox.Image = img;
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

        private void AndromedaBox_Click(object sender, EventArgs e)
        {

        }

        private void MikuAnim_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void MikuAnim_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
