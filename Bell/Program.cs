using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RcisSchoolBell.lib;
using RcisSchoolBell.lib.AES;
using RcisSchoolBell.lib.UHWID;

namespace RcisSchoolBell
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            var uhwid = new UhwidEngine();

            //0033C6A8BFEBFBFF0004065178D78DEB08D2A6E3859728686F310C5D

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var f = new Form1();
            Logger.Hook();

            if (args.Length > 0 && args[0] != null)
            {
                if (args[0].Contains("-m") || args[0].Contains("-M") || args[0].Contains("/m") || args[0].Contains("/M"))
                {
                    f.WindowState = FormWindowState.Minimized;
                }
            }
            if (args.Length > 0 && args[1] != null)
            {
                if (args[1].Contains("-gr") || args[1].Contains("-GR")
                    || args[1].Contains("/GR") || args[1].Contains("/GR"))
                {
                    var sr = new StreamWriter(Application.StartupPath + "\\id.txt");
                    sr.WriteLine(uhwid.AdvancedUid);
                    sr.WriteLine(AesCryp.Encrypt(uhwid.AdvancedUid));
                    sr.Flush();
                    sr.Close();
                    Process.Start("id.txt");
                }
            }

            if (AesCryp.Decrypt(File.ReadAllText(Application.StartupPath + "\\Bell.txt").Trim()) == uhwid.AdvancedUid)
            {


                //MessageBox.Show(uhwid.AdvancedUid.Length.ToString());
                try
                {

                    if (CheckFiles.Checkfolder())
                    {
                        if (CheckFiles.CheckAudioFolder())
                        {
                            if (CheckFiles.CheckMp3Folder())
                            {
                                if (CheckFiles.Checkfiles())
                                {
                                    Application.Run(f);
                                    Logger.UnHook();
                                }
                                else
                                {
                                    MessageBox.Show(@"Files not found", @"Error");
                                }
                            }
                        }
                    }

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message, @"IOException");
                }
            }
            else
            {
                MessageBox.Show(@"invalic hwid");
                Logger.UnHook();
            }
        }

        /// <summary>
        /// string NameVirusIsClick = GetFileNameDubleClick();
        /// Get the file you double click at the time.
        /// </summary>
        /// <returns></returns>
        public static string GetFileNameDubleClick()
        {
            // Search only name the virus that we double click to run
            string thisPart = Convert.ToString(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] arraySt = thisPart.Split(char.Parse("\\"));
            int lastSt = arraySt.Length;
            string thisNameAndType = arraySt[lastSt - 1];
            arraySt = thisNameAndType.Split(Char.Parse("."));
            string thisNameClick = arraySt[0];
            return thisNameClick;
        }
        public static bool IsProcessOpen(string name)
        {
            var p = Process.GetProcessesByName(GetFileNameDubleClick());
            if (p.Length != 0)
                return Process.GetProcesses().Any(clsProcess => clsProcess.ProcessName.Contains(name));
            return false;
        }
    }
}
