using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("how many times do you want it printed per line?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many lines do you want printed?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int counter2 = 0;
            while (counter < num2)
            {
                Console.WriteLine();
                counter2 = 0;
                while (counter2 < num)
                {
                    Console.Write(name);
                    counter2++;
                }
                counter++;
            }
        }
    }
}
