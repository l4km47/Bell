using System;
using System.Windows.Forms;
using Microsoft.Win32;
using RcisSchoolBell.Controls;
using RcisSchoolBell.lib;
using RcisSchoolBell.lib.MaterialSkin;

namespace RcisSchoolBell
{
    public partial class FrmSettings : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private string _path;
        public FrmSettings()
        {
            InitializeComponent();
            Title = Text;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = SettingsAdapter.Theme()
                ? MaterialSkinManager.Themes.Light : MaterialSkinManager.Themes.Dark;
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo600,
                Primary.Indigo700, Primary.Indigo200, Accent.Red700, TextShade.White);

        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            start.Text = SettingsAdapter.Starttime().ToString("HH:mm:ss tt");
            ptime.Text = SettingsAdapter.PeriodTime().ToString();
            stime.Text = SettingsAdapter.Songstime().ToString("HH:mm:ss tt");
            list.Text = SettingsAdapter.Playlist();
            _path = SettingsAdapter.Playlist();
            inttime.Text = SettingsAdapter.Interval().ToString();
            lunch.Text = SettingsAdapter.Lunch().ToString();
            themelight.Checked = SettingsAdapter.Theme();
            themedark.Checked = !themelight.Checked;
            RegistryKey k = Registry.CurrentUser.OpenSubKey(
                   @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            try
            {
                if (k != null)
                {
                    startup.Checked = !string.IsNullOrEmpty(k.GetValue("Bell").ToString());

                    k.Close();
                }
            }
            catch (Exception)
            {
                if (k != null) k.Close();
                startup.Checked = false;
                //MessageBox.Show(ex.Message);
            }
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                DialogResult dr = MessageBox.Show(@"Exit without saving?", @"Exit | Save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            if (DialogResult == DialogResult.OK)
            {
                SettingsAdapter.Starttime(start.Text.ToTime());
                SettingsAdapter.PeriodTime(ptime.Text.ToInt());
                SettingsAdapter.Songstime(stime.Text.ToTime());
                SettingsAdapter.Playlist(_path);
                SettingsAdapter.Interval(inttime.Text.ToInt());
                SettingsAdapter.Lunch(lunch.Text.ToInt());
                SettingsAdapter.Theme(themelight.Checked);

                SettingsAdapter.Save();

                _materialSkinManager.Theme = SettingsAdapter.Theme() ?
                    MaterialSkinManager.Themes.Light : MaterialSkinManager.Themes.Dark;
                //  try
                //  {
                RegistryKey k = Registry.CurrentUser.OpenSubKey(
                       @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (startup.Checked)
                {
                    try
                    {
                        if (k != null) k.DeleteValue("Bell");
                    }
                    catch
                    {
                        // ignored
                    }
                    if (k != null)
                    {
                        k.SetValue("Bell", Application.ExecutablePath.Replace(@"/", @"\"), 
                            RegistryValueKind.String);
                        k.Close();
                    }
                }
                else
                {
                    try
                    {
                        if (k != null) k.DeleteValue("Bell");
                    }
                    catch
                    {
                        // ignored
                    }
                    if (k != null) k.Close();
                }
                // }
                //// catch { }

            }
        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _path = folderBrowserDialog1.SelectedPath;
                
                list.Text = folderBrowserDialog1.SelectedPath.ToShortDots(26);
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void themelight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            start.Text = @"07:00:00 AM";
            ptime.Text = @"40";
            stime.Text =@"06:45:00 AM";
            list.Text = Application.StartupPath+@"\\bin\\mp3";
            _path =list.Text;
            inttime.Text = @"15";
            lunch.Text = @"20";
            themelight.Checked = true;
            themedark.Checked = !themelight.Checked;
            RegistryKey k = Registry.CurrentUser.OpenSubKey(
                   @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            try
            {
                if (k != null)
                {
                    startup.Checked = !string.IsNullOrEmpty(k.GetValue("Bell").ToString());

                    k.Close();
                }
            }
            catch (Exception)
            {
                if (k != null) k.Close();
                startup.Checked = false;
                //MessageBox.Show(ex.Message);
            }
        
        }


    }
}
