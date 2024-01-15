using System;
using System.Timers;

namespace My_Daily_Tasks
{

    class NotificationHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string[] songs = { "21 Pilots - Heathens.mp3", "Aerosmith - Eat the rich.mp3", "Avenge Sevenfold - Hail to the king.mp3", "Beatie Boys - Sabotage.mp3", 
            "Cinderella - If You Don't Like It.mp3", "Disturbed - Indestructible.mp3", "Dokken - Mr Scary.mp3", "Led Zeppelin - Immigrant Song.mp3", "Megadeth - Symphony Of Destruction.mp3",
            "Rage Against The Machine - Killing In the Name.mp3", "Rage Against The Machine - Testify.mp3", "Rammstein - Feuer Frei!.mp3", "Ratt - Way Cool Jr..mp3", "Slade - Run Run Away.mp3",
            "Savatage - Hall of the Mountain King.mp3", "The Cult - Fire Woman.mp3"};
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
            Random random = new Random();
            int index = random.Next(songs.Length);
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer
            {
                URL = ""+ songs[index] +""
            };
            player.controls.play();
        }

        public void StopNotifications()
        {
            notification.Enabled = false;
            log.Info("Notifications stopped.");
        }

    }
}
