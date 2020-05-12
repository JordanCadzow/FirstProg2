using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter2 = 0;
            Console.WriteLine("how many x to start with?");
            int counter = Convert.ToInt32(Console.ReadLine());
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
