using System;

namespace IntroArrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            int counter = 0;
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            while (counter < 5)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("Goodbye " + name);
            
        }
    }
}
