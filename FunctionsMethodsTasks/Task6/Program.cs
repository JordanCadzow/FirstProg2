using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Program prgrm = new Program();
            prgrm.Swap(ref num1, ref num2);
            Console.WriteLine("Now the 1st number is " + num1 + " and the 2nd number is " + num2); 
        }
        public void Swap(ref int num1, ref int num2) {
            int tempNum = num1;
            num1 = num2;
            num2 = tempNum;



        }
    }
}
