using System;

namespace Tast1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine(total);
        }
    }
}
