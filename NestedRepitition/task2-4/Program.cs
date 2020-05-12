using System;

namespace task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter2 = 0;
            int counter = 1;
            Console.WriteLine("How many lines ?"); //im assuming this doesnt count as one of the writeline commands, its just to help the user >.<
            int num = Convert.ToInt32(Console.ReadLine());
            while (counter <= num)
            {
                Console.WriteLine();
                counter2 = 0;
                while (counter2 < counter)
                {
                    Console.Write("x");
                    counter2 = counter2 + 1;
                }
                counter = counter + 1;
            }
        }
    }
}
