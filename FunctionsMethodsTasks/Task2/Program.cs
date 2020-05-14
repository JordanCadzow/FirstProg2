using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome wlcm = new Welcome();
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            wlcm.Output(name);
        }

        
    }
    public class Welcome {
        
        public void Output(string name) {
            Console.WriteLine("Welcome " + name + "!");
            Console.WriteLine("Have a nice day!");
        }
    }
}
