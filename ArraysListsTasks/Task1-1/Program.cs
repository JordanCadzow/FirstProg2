using System;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int counter = 1;
            Console.WriteLine("please enter 5 names");
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write("Name " + counter + ": ");
                names[i] = Console.ReadLine();
                counter = counter + 1;
            }
            foreach (string i in names) 
            {
                Console.WriteLine("Hello " + i);
                

            }
            
        }
    }
}
