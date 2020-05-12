using System;
using System.Collections.Generic;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(9);
            Console.WriteLine("Check what numbers are entered:");
            bool entered = false;
            int numEntered = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numEntered == numbers[i]) 
                {
                    entered = true;
                }
            }
            if (entered == false) 
            {
                Console.WriteLine("number has not been entered");
            }
            else 
            {
                Console.WriteLine("number exists in array");
            }


        }
    }
}
