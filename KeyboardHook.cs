using System.Windows.Forms;
using Utilities;
using System;

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
               
                    toggle = false;
                }
            }

        }

       
    }
}
