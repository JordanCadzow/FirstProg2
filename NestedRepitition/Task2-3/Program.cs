using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter2 = 0;
            int counter = 1;
            while (counter < 6)
            {
                Console.WriteLine();
                counter2 = 0;
                while (counter2 < counter)
                {
                    Console.Write("x");
                    counter2 = counter2 + 1;
                }
                counter = counter + 1;
            }
        }
    }
}
