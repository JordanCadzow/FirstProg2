using System;

namespace IntroProgSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            int legalAge = 18;
            if(age >= legalAge)
            {
               Console.WriteLine("You are permitted to get turnt");
            }
            else
            {
                Console.WriteLine("You are forbidden from drinking");
            }
        }
    }
}
