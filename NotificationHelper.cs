using System.Timers;
using System.Media;

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
            SoundPlayer soundPlayer = new SoundPlayer
            {
                SoundLocation = "Rage Against The Machine - Killing In the Name.mp3"
            };
            soundPlayer.Play();
        }

        public void StopNotifications()
        {
            notification.Enabled = false;
            log.Info("Notifications stopped.");
        }

    }
}
