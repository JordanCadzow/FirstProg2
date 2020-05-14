using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prgrm = new Program();
            prgrm.Prime();
        }
        public void Prime() {
            int n, i, m=0, flag=0;    
            Console.Write("Enter the Number to check Prime: ");    
            n = int.Parse(Console.ReadLine());  
            m=n/2;    
            for(i = 2; i <= m; i++)    
            {    
            if(n % i == 0)    
                {    
                Console.Write(n + " is not Prime.");    
                flag=1;    
                break;    
                }    
            }    
            if (flag == 0)    
            Console.Write(n + " is Prime.");  
        }
    }
}
