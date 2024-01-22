using System;
using System.IO;
using System.Timers;

namespace My_Daily_Tasks
{

    class NotificationHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly Timer notificationTimer = new Timer();
        private static readonly string path = "Songs\\";
        private static readonly string[] songs = Directory.GetFiles(path);
        private readonly WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private readonly Random random = new Random();

        public NotificationHelper()
        {
            log.Info("Notifications called!");
        }

        public void StartNotifications()
        {
            notificationTimer.Elapsed += new ElapsedEventHandler(Notification);
            notificationTimer.Interval = 3600000;
            notificationTimer.Enabled = true;
            log.Info("Notifications started.");
        }

        private void Notification(object source, ElapsedEventArgs e)
        {
            log.Info("Notification playing");
            player.URL = songs[random.Next(songs.Length)];
            player.settings.volume = 50;
            player.controls.play();
        }

        public void StopNotifications()
        {
            notificationTimer.Enabled = false;
            log.Info("Notifications stopped.");
        }

    }
}
