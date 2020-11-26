using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    class Phone : MusicFile , MusicPlayerInterface
    {
        private MusicFile[] musicFiles;
        private int musicFileCount;
        public int MusicFileCount
        {
            get { return musicFileCount; }
            set { musicFileCount = value; }
        }
        public Phone() 
        {
            musicFiles = new MusicFile[500];
            musicFileCount = 0;
        }
        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds) : base( title,  artist, yearOfRelease, durationInSeconds)
        {
            musicFiles = new MusicFile[500];
            musicFileCount = 0;

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
        public void retune(double frequencyLevel)
        {
            Console.WriteLine("The Radio Player Cuurent Frequency Number : " + frequencyLevel);
        }
        public void AddMusicFile(params MusicFile[] musicFiles)
        {
            foreach (var a in musicFiles)
            {
                if (musicFileCount < 500)
                {
                    this.musicFiles[musicFileCount++] = a;
                }
                else
                {
                    Console.WriteLine("Cannot Create Account:  " + a.Title);
                }
            }
        }
        public void ShowAllMusicFile()
        {
            for (int i = 0; i < musicFileCount; i++)
            {
                this.musicFiles[i].ShowInfo();
                
            }
        }
        public void playNext()
        {
            Console.WriteLine("Next Music In The PlayList Of The MusicPlayer.");
            for (int i = 1; i < musicFileCount; i++)
            {
                this.musicFiles[i+1].ShowInfo();
                break;
            }
        }

        public void playPrevious()
        {
            Console.WriteLine("Previous Music In The PlayList Of The MusicPlayer.");
            for (int i = 0; i < musicFileCount; i++)
            {
                this.musicFiles[i].ShowInfo();
                break;
            }
        }

        public void changeChannel()
        {
            Console.WriteLine("Changing The Radio Channel.");
        }

    }
    
}
