using System;

namespace IntroProgSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int legalAge = 18;
            int schoolAge = 16;

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= legalAge && age >= schoolAge)
            {
               Console.WriteLine("You are permitted to get turnt.");
               Console.WriteLine("You can leave school, if you haven't already.");
            }
            else if(age >= schoolAge)
            {
                Console.WriteLine("You are forbidden from drinking.");
                Console.WriteLine("You can leave school.");
            }
            else
            {
                Console.WriteLine("You cannot drink OR leave school.");
            }

        }
    }
}
