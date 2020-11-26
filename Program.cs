using System;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Phone m1 = new Phone("It's the Most Wonderful Time of the Year", "Andy Williams", 2020, 300);
            m1.ShowInfo();
            m1.changeTitle("It is the Most Wonderful Time of the Year");
            m1.ShowInfo();
        }
    }
}
