using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class Phone : MusicFile , MusicPlayerInterface
    {
        public Phone() { }
        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds) : base( title,  artist, yearOfRelease, durationInSeconds)
        {

        }
        public void switchs( bool currentMode)
        {
            bool start = true;
            bool stop = false;
            if (currentMode == true)
            {
                Console.Write("The Music Player Switch On In The Phone");
            }
            else
            {
                Console.Write("The Music Player Switch Off In The Phone");
            }
        }
        public void play(bool currentMode)
        {
            bool start = true;
            bool stop = false;
            if (currentMode == true)
            {
                Console.WriteLine("The Music Player Is Playing Music On The Phone");
            }
            else
            {
                Console.WriteLine("The Music Player Is Not Playing Music On The Phone");
            }
        }
        public void setVolume(int loudnessLevel)
        {

            if (loudnessLevel >= 0)
            {
                Console.WriteLine("The Music Player Music Loudness Level Is Now : " + loudnessLevel);
            }
            else
            {
                Console.WriteLine("Volume Is Set Now On ''0'' ");
                Console.WriteLine("The Music Player Music Loudness Level In Negative Level That Why " + loudnessLevel + "Considered As 0 Level Loudness.");
            }
        }

        public void playNext()
        {
            Console.WriteLine("Next Music In The PlayList Of The MusicPlayer.");
        }

        public void playPrevious()
        {
            Console.WriteLine("Previous Music In The PlayList Of The MusicPlayer.");
        }

        public void changeChannel()
    {
            Console.WriteLine("Changing The Radio Channel.");
        }

    }
    
}
