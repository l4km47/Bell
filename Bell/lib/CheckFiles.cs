using System.IO;
using System.Windows.Forms;

namespace RcisSchoolBell.lib
{
    public static class CheckFiles
    {
        public static bool Checkfolder()
        {
            if (!Directory.Exists(Application.StartupPath + "\\bin"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\bin");
                return true;
            }
           
            return true;
        }

        public static bool CheckAudioFolder()
        {
            if (!Directory.Exists(Application.StartupPath + "\\bin\\audio"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\bin\\audio");
                return true;
            }
            return true;
        }

        public static bool CheckMp3Folder()
        {
            if (!Directory.Exists(Application.StartupPath + "\\bin\\mp3"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\bin\\mp3");
                return true;
            }
            return true;
        }
        public static bool Checkfiles()
        {
            var s = Directory.GetFiles(Application.StartupPath + "\\bin\\audio", "*.mp3");

            return s.Length > 0;
        }
    }
}
