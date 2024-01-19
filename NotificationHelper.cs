using System;
using System.IO;
using System.Timers;

namespace My_Daily_Tasks
{

    class NotificationHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string path = "Songs\\";
        private static readonly string[] songs = Directory.GetFiles(path);
        private readonly Random random = new Random();
        private readonly Timer notification = new Timer();

        public NotificationHelper()
        {
            log.Info("Notifications called! " + String.Join(", ", songs));
        }

        public void StartNotifications()
        {
            notification.Elapsed += new ElapsedEventHandler(Notification);
            notification.Interval = 3600000;
            notification.Enabled = true;
            log.Info("Notifications started.");
        }

        private void Notification(object source, ElapsedEventArgs e)
        {
            string song = songs[random.Next(songs.Length)];
            log.Info("Notification playing" + song);
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer
            {
                URL = song
            };
            player.controls.play();
            NotificationForm notificationForm = new NotificationForm(song, player);
            notificationForm.Show();
        }

        public void StopNotifications()
        {
            notification.Enabled = false;
            log.Info("Notifications stopped.");
        }

    }
}
