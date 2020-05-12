using System;

namespace RepititionTasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1 and 10. What is it?");
            bool correct = false;
            int number = 5;
            while (correct == false)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number) {
                    correct = true;
                }
                else {
                    Console.WriteLine("Incorrect, guess again.");
                }
                


            }
            Console.WriteLine("Well Done!");
        }
    }
}
