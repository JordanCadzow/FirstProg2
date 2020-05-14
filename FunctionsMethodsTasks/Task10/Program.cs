using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prgrm = new Program();
            Console.WriteLine(2 % 10);
            prgrm.sumDigits();
        }

        public void sumDigits() {
            int n, sum=0, m;         
            Console.Write("Enter a number: ");      
            n = int.Parse(Console.ReadLine());     
            while(n>0) {      
                m =  n % 10;      
                sum = sum + m;      
                n = n / 10;      
                }      
            Console.Write("Sum is " + sum); 
        }
    }
}
