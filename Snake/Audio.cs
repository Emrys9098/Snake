using System;

using System.Windows.Media;

namespace snake
{

    public static class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("goofy-ahh-android-low-quality.wav");
        private static MediaPlayer LoadAudio(string filename, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            player.Volume = 10;
            return player;
        }





    }


}