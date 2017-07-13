using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace RcisSchoolBell.lib.UHWID
{
    internal class WindowsId
    {
        public static string GetWindowsId()
        {
            return Windowsid();
        }
        private static string Windowsid()
        {
            var windowsInfo = "";
            var managClass = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

            var managCollec = managClass.Get();

            var is64Bits = Environment.Is64BitOperatingSystem;
            
            foreach (var o in managCollec)
            {
                var managObj = (ManagementObject) o;
                windowsInfo = managObj.Properties["Caption"].Value + Environment.UserName + (string)managObj.Properties["Version"].Value;
                break;
            }
            windowsInfo.Replace(" ", "");
            windowsInfo.Replace("Windows", "");
            windowsInfo.Replace("windows", "");
            windowsInfo += (is64Bits) ? " 64bit" : " 32bit";

            //md5 hash of the windows version
            var md5Hasher = MD5.Create();
            var wi = md5Hasher.ComputeHash(Encoding.Default.GetBytes(windowsInfo));
            var wiHex = BitConverter.ToString(wi);
            wiHex = wiHex.Replace("-", "");
           return wiHex;
        }
    }
}