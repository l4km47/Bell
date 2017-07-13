using System.IO;
using System.Management;

namespace RcisSchoolBell.lib.UHWID
{
    internal class DiskId
    {
        public static string GetDiskId()
        {
            return Diskid();
        }
        public static string GetDiskId(string diskLetter)
        {
            return Diskid(diskLetter);
        }

        private static string Diskid(string diskLetter = "")
        {
            //Find first drive
            if (diskLetter == "")
            {
                foreach (var compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        diskLetter = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }
            if (diskLetter.EndsWith(":\\"))
            {
                //C:\ -> C
                diskLetter = diskLetter.Substring(0, diskLetter.Length - 2);
            }
            var disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + diskLetter + @":""");
            disk.Get();

            var volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }
    }
}