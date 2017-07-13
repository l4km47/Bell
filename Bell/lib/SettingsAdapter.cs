using System;
using RcisSchoolBell.Properties;

namespace RcisSchoolBell.lib
{
    public static class SettingsAdapter
    {
        #region "=======================start time===================="
        //get start time
        public static DateTime Starttime()
        {
            return Settings.Default.starttime;
        }

        //save start time
        public static void Starttime(DateTime time)
        {
            Settings.Default.starttime = time;
            Save();
        }
        #endregion

        #region "=======================interval time===================="
        //get interval 
        public static int Interval()
        {
            return Settings.Default.interval;
        }

        //save interval
        public static void Interval(int time)
        {
            Settings.Default.interval = time;
            Save();
        }
        #endregion

        #region "=======================lunch time===================="
        //get lunch 
        public static int Lunch()
        {
            return Settings.Default.lunch;
        }

        //save lunch
        public static void Lunch(int time)
        {
            Settings.Default.lunch = time;
            Save();
        }
        #endregion

        #region "=======================time for period===================="
        //get time for period 
        public static int PeriodTime()
        {
            return Settings.Default.peroidtime;
        }

        //save time for period
        public static void PeriodTime(int time)
        {
            Settings.Default.peroidtime = time;
            Save();
        }
        #endregion


        #region "=======================songs start time===================="
        //get time for period 
        public static DateTime Songstime()
        {
            return Settings.Default.songstarttime;
        }

        //save time for period
        public static void Songstime(DateTime time)
        {
            Settings.Default.songstarttime = time;
            Save();
        }
        #endregion

        #region "=======================playlist path===================="
        //get time for period 
        public static string Playlist()
        {
            return Settings.Default.playlist;
        }

        //save time for period
        public static void Playlist(string path)
        {
            Settings.Default.playlist = path;
            Save();
        }
        #endregion

        #region "=======================playlist path===================="

        public static bool Theme()
        {
            return Settings.Default.theme;
        }

        public static void Theme(bool t)
        {
            Settings.Default.theme = t;
            Save();
        }
        #endregion


        public static void Save()
        {
            Settings.Default.Save();
        }
    }
}
