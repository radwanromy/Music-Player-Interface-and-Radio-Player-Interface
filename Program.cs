using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|||||||||||||||||||||||Music About||||||||||||||||||||||||||");
            
            Phone m1 = new Phone("It's the Most Wonderful Time of the Year", "Andy Williams", 2020, 300);
            m1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||Change Title|||||||||||||||||||||||||");
            m1.changeTitle("It is the Most Wonderful Time of the Year");
            m1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||Swich On Call|||||||||||||||||||||||||");
            m1.switchs(true);
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||Music Play On Call ||||||||||||||||||||||");
            m1.play(true);
            Console.WriteLine();
            Console.WriteLine("||||||||||||||Set Volume Call with Loudness 5|||||||||||||||");
            m1.setVolume(5);
            Phone m2 = new Phone("Jingle Bell Rock", "Bobby Helms", 2020, 300);
            Phone m3 = new Phone("Holly Jolly Christmas", "Burl Ives", 2020, 300);
            Phone m4 = new Phone("Memories", "Maroon 5", 2020, 300);
            Phone list = new Phone();
            list.AddMusicFile(m2, m1, m3, m4);
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||Next Music Info|||||||||||||||||||||||");
            list.playNext();
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||Previous Music Info|||||||||||||||||||||");
            list.playPrevious();
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||||Music List||||||||||||||||||||||||||");
            
            
            list.ShowAllMusicFile();
            
        }
    }
}
