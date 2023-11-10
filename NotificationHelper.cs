using System.Timers;

namespace My_Daily_Tasks
{

    class NotificationHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly Timer notification = new Timer();

        public NotificationHelper()
        {
            log.Info("Notifications called!");
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
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "Rage Against The Machine - Killing In the Name.mp3";
            player.controls.play();
        }

        public void StopNotifications()
        {
            notification.Enabled = false;
            log.Info("Notifications stopped.");
        }

    }
}
