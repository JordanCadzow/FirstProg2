using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            Console.Write("Enter the number of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Program prgrm = new Program();  
            prgrm.Sequence(number, n1, n2, n3);

        }
        public void Sequence(int Number, int n1, int n2, int n3) {
            for(int i=0; i < Number; i++) {
                Console.WriteLine(n1);
                
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }


        }
    }
}
