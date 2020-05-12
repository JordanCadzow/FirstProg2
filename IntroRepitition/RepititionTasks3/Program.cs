using System;

namespace RepititionTasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 1000:");
            Random random = new Random();
            int num = random.Next(1000);
            int counter = 0;
            Console.WriteLine(num);
            


        }
    }
}
