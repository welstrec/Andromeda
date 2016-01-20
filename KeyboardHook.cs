using System.Windows.Forms;
using Utilities;
using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace MikuDash
{
    public class KeyboardHook
    {
        private globalKeyboardHook gkh;
        private MikuDashMain spr;
        Boolean toggle = false;
        public KeyboardHook(MikuDashMain spr)
        {
            this.spr = spr;
           
            gkh = new globalKeyboardHook();
            gkh.OnKeyPressed += KeyDown;

            gkh.HookKeyboard();

            //actHook.OnMouseActivity += new MouseEventHandler(MouseMoved);
            //HookManager.KeyDown += KeyDown;
            //actHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
            // HookManager.KeyUp += KeyUp;
        }


        private void KeyDown(object sender, KeyPressedArgs e)
        {

            if (e.KeyPressed.ToString() == Keys.Pause.ToString())
            {
                if (!toggle) { 
                spr.sprOn();
                    toggle = true;


            } else
            {
                spr.sprOff();
                spr.stopAlertMemory();
                spr.stopAlertTemp();
                spr.overrideAlert = true;
                    toggle = false;
                }
            }

        }

       
    }
}
