using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;
            int counter2 = 5;
            while (counter > 0)
            {
                Console.WriteLine();
                counter2 = 0;
                while (counter2 < counter)
                {
                    Console.Write("x");
                    counter2 = counter2 + 1;
                }
                counter = counter - 1;
            }
        }
    }
}
