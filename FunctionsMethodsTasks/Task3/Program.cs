using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Program prgrm = new Program();
            Console.WriteLine(prgrm.Addition(Num1, Num2));
        }
            public string Addition(int num1, int num2) {
                return "The sum of two numbers is: " + (num1+num2);
        }
    }
}
