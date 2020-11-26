using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_3
{
    abstract class MusicFile
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }
        public MusicFile()
        {
        }
        public MusicFile(string title, string artist, int yearOfRelease , int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
            /*
            Music = new Music[10];
            musicCount = 0; */
        }
        public void changeTitle(string newTitle)
        {
            title = newTitle;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Music Title : " + title);
            Console.WriteLine("Music Artist : " + artist);
            Console.WriteLine("Music Release Year : " + yearOfRelease);
            Console.WriteLine("Music Duration Is " + durationInSeconds + " Seconds");
        }
    }
}
