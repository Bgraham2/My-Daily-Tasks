using System;
using System.IO;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class Notifications : Form
    {
        private static readonly string path = "Songs\\";
        private static readonly string[] songs = Directory.GetFiles(path, "*.mp3");
        private readonly WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly Random random = new Random();
       
        public Notifications()
        {
            InitializeComponent();
            String song = songs[random.Next(songs.Length)];
            labelSongTitle.Text = song.Substring(6, song.Length - 10);
            log.Info("Notification playing with volume: " + trackBarVolume.Value);
            player.URL = song;
            player.settings.volume = trackBarVolume.Value;
            player.controls.play();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Close();
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBarVolume.Value;
        }
    }
}
