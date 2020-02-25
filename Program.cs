using System;

namespace FirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine("What year were you born?");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the current year?");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            int age = currentYear - birthYear;
            Console.WriteLine("So you are " + age + " years old!");
        }
    }
}
