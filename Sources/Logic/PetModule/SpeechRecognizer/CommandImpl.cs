using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace MikuDash
{
    public class CommandImpl
    {
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170; 
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        private IntPtr hwnd;
        private MikuDashMain mdm;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern short VkKeyScan(char ch);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        public Listener lsit;
        public SpeechRecognizer spr;

        public CommandImpl(IntPtr handle, MikuDashMain appcmd, Listener ls, SpeechRecognizer spr)
        {
            hwnd = handle;
            mdm = appcmd;
            this.spr = spr;
            lsit = ls;
        }

        public void turnOffScreens()
        {
            Console.WriteLine("poff");
            SendMessage(hwnd.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        public void turnOnScreens()
        {
            Console.WriteLine("pon");
            SendMessage(hwnd.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }

        public void show()
        {
            mdm.showApps();
        }
        public void hide()
        {
            mdm.hideApps();
        }
        public void disableListener()
        {
            mdm.sprOff();
        }

        public void volumeUp()
        {
            mdm.listener.volumeUp();
        }

        public void volumeDown()
        {
            mdm.listener.volumeDown();
        }

        public void mute()
        {
            mdm.listener.mute();
        }

        public void unMute()
        {
            mdm.listener.resume();
        }
        public void mediaPlay()
        {
            SendKeyAsInput((int)Keys.MediaPlayPause,10);
        }
        public void openBrowser(String url)
        {
            Process.Start(url);
        }

        public void openApp(String location)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = location;
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
        }

        public static void SendKeyAsInput(short key, int HoldTime)
        {
            INPUT INPUT1 = new INPUT();
            INPUT1.type = (int)InputType.INPUT_KEYBOARD;
            INPUT1.ki.wVk = (short)key;
            INPUT1.ki.dwFlags = (int)KEYEVENTF.KEYDOWN;
            INPUT1.ki.dwExtraInfo = GetMessageExtraInfo();
            SendInput(1, new INPUT[] { INPUT1 }, Marshal.SizeOf(INPUT1));

            WaitForSingleObject((IntPtr)0xACEFDB, (uint)HoldTime);

            INPUT INPUT2 = new INPUT();
            INPUT2.type = (int)InputType.INPUT_KEYBOARD;
            INPUT2.ki.wVk = (short)key;
            INPUT2.mi.dwFlags = (int)KEYEVENTF.KEYUP;
            INPUT2.ki.dwExtraInfo = GetMessageExtraInfo();
            SendInput(1, new INPUT[] { INPUT2 }, Marshal.SizeOf(INPUT2));

        }

    }
    
        [StructLayout(LayoutKind.Explicit)]
        public struct INPUT
        {
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(0)]
            public int type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [Flags]
        public enum InputType
        {
            INPUT_MOUSE = 0,
            INPUT_KEYBOARD = 1,
            INPUT_HARDWARE = 2
        }

        [Flags]
        public enum MOUSEEVENTF
        {
            MOVE = 0x0001, /* mouse move */
            LEFTDOWN = 0x0002, /* left button down */
            LEFTUP = 0x0004, /* left button up */
            RIGHTDOWN = 0x0008, /* right button down */
            RIGHTUP = 0x0010, /* right button up */
            MIDDLEDOWN = 0x0020, /* middle button down */
            MIDDLEUP = 0x0040, /* middle button up */
            XDOWN = 0x0080, /* x button down */
            XUP = 0x0100, /* x button down */
            WHEEL = 0x0800, /* wheel button rolled */
            MOVE_NOCOALESCE = 0x2000, /* do not coalesce mouse moves */
            VIRTUALDESK = 0x4000, /* map to entire virtual desktop */
            ABSOLUTE = 0x8000 /* absolute move */
        }

        [Flags]
        public enum KEYEVENTF
        {
            KEYDOWN = 0,
            EXTENDEDKEY = 0x0001,
            KEYUP = 0x0002,
            UNICODE = 0x0004,
            SCANCODE = 0x0008,
        }
    
}
