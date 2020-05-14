using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            Console.WriteLine("Input 5 elements in the array:");
            Program prgrm = new Program();

            Console.WriteLine("The sum of the elements in the array is " + prgrm.Sum(Numbers));

        }
        public int Sum(int[] numbers) {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("Element " + i + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++) {
                total = total + numbers[i];
            }
            
            return total;
        }
    }
}
