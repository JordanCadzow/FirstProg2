using System;
using System.Collections.Generic;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(9);
            Console.WriteLine("Check what numbers are entered:");
            bool entered = false;
            int counter = 0;
            int numEntered = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numEntered == numbers[i]) 
                {
                    entered = true;
                    counter++;
                }
            }
            if (entered == false) 
            {
                Console.WriteLine("number has not been entered");
            }
            else 
            {
                Console.WriteLine("number exists " + counter + " time(s) in array");
                
            }
        }
    }
}
