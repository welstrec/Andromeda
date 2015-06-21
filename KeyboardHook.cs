using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.UserActivityMonitor;
namespace MikuDash
{
    public class KeyboardHook
    {
        MikuDashMain spr;
        public KeyboardHook(MikuDashMain spr)
        {
            this.spr = spr;
            //actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);
            HookManager.KeyDown += KeyDown;
            //actHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
            HookManager.KeyUp += KeyUp;
        }



        private void KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Pause)
            {
                spr.sprOn();
            }
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Pause)
            {
                spr.sprOff();
                spr.stopAlertMemory();
                spr.stopAlertTemp();
                spr.overrideAlert = true;
            }
        }
    }
}
