using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AxWMPLib;
using RcisSchoolBell.Controls;
using RcisSchoolBell.lib;
using RcisSchoolBell.lib.MaterialSkin;
using RcisSchoolBell.Properties;
using WMPLib;

namespace RcisSchoolBell
{
    public partial class Form1 : MaterialForm
    {
        public static string SoftwareCompleteName
        {
            get
            {
                var ver = Application.ProductVersion.Split('.');
                return Application.ProductName + " " + ver[0] + "." + ver[1];
            }
        }
        public Form1()
        {

            InitializeComponent();

            var digclk = new DigitalClockCtrl
            {
                Size = new Size(tableLayoutPanel1.GetColumnWidths()[5], tableLayoutPanel1.GetRowHeights()[8]),
                Location = new Point(0, 0),
            };
            tableLayoutPanel1.Controls.Add(digclk, 5, 8);
            digclk.SetDigitalColor = DigitalColor.BlueColor;
            digclk.BackColor = MaterialSkinManager.BackgroundDark;
            player.CurrentItemChange += player_CurrentItemChange;
            Icon = Resources.ic_launcher;
            Title = SoftwareCompleteName;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = SettingsAdapter.Theme() ? MaterialSkinManager.Themes.Light : MaterialSkinManager.Themes.Dark;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo600,
                Primary.Indigo700, Primary.Indigo200, Accent.Red100, TextShade.White);

            var t = new[] {start,classmanagment, f1,f2, f3,fd,
                p1,attendtime
                , p2, p3, p4,
                interval,
                p5, p6, 
                lunch, 
                p7, p8,end8,end0,end,yo };
            foreach (var textField in t)
            {
                textField.ReadOnly = true;
            }


        }

        private void player_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {

        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        //private readonly string _connectionString = SettingsAdapter.Connection();
        //private MySqlConnection _con;
        //MySqlDataAdapter _adapter;
        //DataTable _dtItems;

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private DateTime[] _p = new DateTime[20];
        // ReSharper disable once FieldCanBeMadeReadOnly.Local

        private IWMPPlaylist _playlistp;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox3.Width = Width - 3;
                pictureBox1.Parent = pictureBox3;
                pictureBox1.Location = new Point(0, pictureBox3.Height - pictureBox1.Height);
                Reload();
            }
            catch
            {
                //
            }
        }

        private void Reload()
        {
            try
            {
                if (TimeBetween(DateTime.Now, SettingsAdapter.Songstime().TimeOfDay,
                    SettingsAdapter.Starttime().TimeOfDay))
                {
                    _playlistp = player.newPlaylist("songs", "");

                    if (!string.IsNullOrEmpty(SettingsAdapter.Playlist()))
                    {
                        foreach (var f in Player.Playlist(SettingsAdapter.Playlist()))
                        {
                            _playlistp.appendItem(player.newMedia(f));
                        }

                        player.currentPlaylist = _playlistp;
                        var index = Settings.Default.file;

                        // Get the media item at the fourth position in the current playlist.
                        var media = player.currentPlaylist.get_Item(index);

                        // Play the media item.
                        player.Ctlcontrols.playItem(media);
                        // player.Ctlcontrols.currentPosition = Settings.Default.lasttime;
                    }
                    else
                    {
                        foreach (var f in Player.Playlist(Application.StartupPath + "\\bin\\mp3"))
                        {
                            _playlistp.appendItem(player.newMedia(f));
                        }

                        player.currentPlaylist = _playlistp;
                        var index = Settings.Default.file;

                        // Get the media item at the fourth position in the current playlist.
                        var media = player.currentPlaylist.get_Item(index);

                        // Play the media item.
                        player.Ctlcontrols.playItem(media);
                        // player.Ctlcontrols.currentPosition = Settings.Default.lasttime;
                    }
                }
                player.Ctlcontrols.pause();

                materialLabel1.Text = lib.Assemblyinfo.AssemblyCopyright;
                var j = SettingsAdapter.PeriodTime();
                var ppl = SettingsAdapter.Starttime();

                start.Text = ppl.ToString("HH:mm:ss tt");
                _p[0] = CalculatedtimeDateTime(0, ppl.Hour, ppl.Minute); //classroom

                _p[1] = CalculatedtimeDateTime(10, _p[0].Hour, _p[0].Minute); //f1

                _p[2] = CalculatedtimeDateTime(2, _p[1].Hour, _p[1].Minute); //f2

                _p[3] = CalculatedtimeDateTime(2, _p[2].Hour, _p[2].Minute); //f3

                _p[4] = CalculatedtimeDateTime(2, _p[3].Hour, _p[3].Minute); //nnnnnnn

                _p[5] = CalculatedtimeDateTime(14, _p[4].Hour, _p[4].Minute); //p1

                _p[6] = CalculatedtimeDateTime(j, _p[5].Hour, _p[5].Minute); //attend

                _p[7] = CalculatedtimeDateTime(5, _p[6].Hour, _p[6].Minute); //p2

                _p[8] = CalculatedtimeDateTime(j, _p[7].Hour, _p[7].Minute);

                _p[9] = CalculatedtimeDateTime(j, _p[8].Hour, _p[8].Minute);

                _p[10] = CalculatedtimeDateTime(j, _p[9].Hour, _p[9].Minute);

                _p[11] = CalculatedtimeDateTime(SettingsAdapter.Interval(), _p[10].Hour, _p[10].Minute);

                _p[12] = CalculatedtimeDateTime(j, _p[11].Hour, _p[11].Minute);
                _p[13] = CalculatedtimeDateTime(j, _p[12].Hour, _p[12].Minute);

                _p[14] = CalculatedtimeDateTime(SettingsAdapter.Lunch(), _p[13].Hour, _p[13].Minute);

                _p[15] = CalculatedtimeDateTime(j, _p[14].Hour, _p[14].Minute);
                _p[16] = CalculatedtimeDateTime(j, _p[15].Hour, _p[15].Minute);

                _p[17] = CalculatedtimeDateTime(3, _p[16].Hour, _p[16].Minute);
                _p[18] = CalculatedtimeDateTime(2, _p[17].Hour, _p[17].Minute);
                _p[19] = CalculatedtimeDateTime(0, _p[18].Hour, _p[18].Minute);

                end8.Text = _p[16].ToString("HH:mm:ss tt");
                end0.Text = _p[17].ToString("HH:mm:ss tt");
                end.Text = _p[18].ToString("HH:mm:ss tt");
                yo.Text = _p[19].ToString("HH:mm:ss tt").Replace(":00", ":06");
                var t = new[]
                {
                    classmanagment, f1, f2, f3, fd,
                    p1, attendtime
                    , p2, p3, p4,
                    interval,
                    p5, p6,
                    lunch,
                    p7, p8
                };


                var i = 0;
                foreach (var textBox in t)
                {
                    try
                    {
                        textBox.Text = _p[i].ToString("HH:mm:ss tt")
                                       + @" - " + _p[i + 1].ToString("HH:mm:ss tt");
                        i++;
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }
            catch
            {//
            }

        }
        private DateTime CalculatedtimeDateTime(float mins, int timeh, int timem)
        {
            var h = timeh;
            var m = timem;

            if (Convert.ToInt16(m) + mins > 59)
            {
                h = h + 1;
                m = (int)(m + mins - 60);
            }
            else
                m = (int)(m + mins);
            return new DateTime(2017, 06, 29, h, m, 00);
        }

        private void Play(string fname)
        {
            var p = Application.StartupPath +
                                        "\\bin\\audio\\" + fname + ".mp3";
            var pp2 = player.newPlaylist("times", "");

            pp2.appendItem(player.newMedia(p));

            player.currentPlaylist = pp2;
            nowplaying.Text = "";
        }

        private void bell_Tick(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(SettingsAdapter.Songstime().ToString("HH:mm:ss tt") + "\n" + DateTime.Now.ToString("HH:mm:ss tt"));
                //create graphics
                Bmp = new Bitmap(pictureBox2.Width + 1, pictureBox2.Height + 1);

                _g = Graphics.FromImage(Bmp);
                _g.Clear(BackColor);
                _g.DrawString(DateTime.Now.ToString("hh:mm:ss tt"),
                    new Font(Font.FontFamily.Name, 14), new SolidBrush(label1.ForeColor), new PointF(1, 1));

                _g.Dispose();
                pictureBox2.Image = Bmp;

                var t = new[]
                {
                    start,
                    classmanagment, f1, f2, f3, p1,
                    attendtime, p2, p3, p4, interval,
                    p5, p6, lunch, p7, p8, end8, end0, end, yo
                };

                for (var j = 0; j < t.Length; j++)
                {
                    if (t[j].Text.Substring(0, 11).Equals(DateTime.Now.ToString("HH:mm:ss tt")))
                    {

                        if (j - 1 >= 0)
                        {
                            t[j - 1].BackColor = Color.Red;
                            t[j - 1].ForeColor = Color.Black;
                        }
                        //  catch (Exception) { }
                        t[j].BackColor = Color.Chartreuse;
                        Play(t[j].Name);
                    }
                    // textBox.BackColor = DefaultBackColor;

                }
            }
            catch (Exception)
            {//
            }
        }

        public static Bitmap Bmp;
        private static Graphics _g;


        private static bool TimeBetween(DateTime datetime, TimeSpan start, TimeSpan end)
        {
            // convert datetime to a TimeSpan
            var now = datetime.TimeOfDay;
            // see if start comes before end
            //  if (start < end).
            return now > start && now < end;
            // start is after end, so do the inverse comparison
            // return !(end < now && now < start);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var stat = SettingsAdapter.Songstime();
                var endsong = SettingsAdapter.Starttime();


                if (TimeBetween(DateTime.Now, stat.TimeOfDay, endsong.TimeOfDay))
                {
                    if (player.playState != WMPPlayState.wmppsPlaying)
                    {
                        var index = Settings.Default.file;

                        // Get the media item at the fourth position in the current playlist.
                        var media = player.currentPlaylist.get_Item(index);

                        // Play the media item.

                        player.Ctlcontrols.playItem(media);
                        //  player.Ctlcontrols.currentPosition = Settings.Default.lasttime;

                        materialRaisedButton1.Enabled = false;
                        //   timer1.Stop();
                        //nowplaying.Text =@"Now playing : "
                        //   + axWindowsMediaPlayer1.currentMedia.name.ToShortDots(30);
                        //duration.Text = axWindowsMediaPlayer1.currentMedia.getMarkerTime(0).ToString();
                    }
                }
            }
            catch
            { //
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var frmsettings = new FrmSettings { Icon = Icon };
            Hide();
            if (frmsettings.ShowDialog() == DialogResult.OK)
            {
                Reload();
                Show();
                BringToFront();
            }
            else
            {
                Reload();
                Show();
                BringToFront();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p4_Click(object sender, EventArgs e)
        {

        }

        private void start_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"))
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                    "http://www.rcisl.net");
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                    "http://twitter/l4km47");
                return;
            }

            Process.Start("http://www.rcisl.net");
            Process.Start("http://twitter/l4km47");


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                // int index;
                for (var i = 0; i < player.currentPlaylist.count - 1; i++)
                {

                    if (player.currentMedia.name.Equals(player.currentPlaylist.get_Item(i).name))
                    {
                        Settings.Default.file = i;
                        var timeSpan = TimeSpan.FromSeconds(player.Ctlcontrols.currentPosition);
                        Settings.Default.lasttime = player.Ctlcontrols.currentPosition;
                        Settings.Default.Save();
                        nowplaying.Text = timeSpan.ToString("g");
                        break;
                    }
                }
            }
            catch
            {
                //

            }

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();

            about.ShowDialog();
        }


    }
}
