using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome wlcm = new Welcome();
            wlcm.Output();
        }

        
    }
    public class Welcome {
        
        public void Output() {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
    }
}
