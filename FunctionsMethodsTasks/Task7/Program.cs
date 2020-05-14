using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Base number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Exponent: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Program prgrm = new Program();
            Console.WriteLine("The number " + num1 + "^" + num2 + " = " + prgrm.Raise(num1, num2));
        }
        public double Raise(double Num1, double Num2) {
            return Math.Pow(Num1, Num2);
        }
    }
}
