using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            int counter = 0;
            int counter2 = 0;
            while (counter < 10)
            {
                Console.WriteLine();
                counter2 = 0;
                while (counter2 < 10)
                {
                    Console.Write(name);
                    counter2++;
                }
                counter++;
            }
        }
    }
}
