using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {

            Bee b1 = new Bee('John', 3.2);
            Bee b2 = new Bee('Paul', 2.7);
            Bee b3 = new Bee('George', 1.1);
            Bee b4 = new Bee('Ringo', 2.0);

            Bee b5 = new Bee('Kurt', 2.3);
            Bee b6 = new Bee('Dave', 7.4);
            Bee b7 = new Bee('Krist', 1.5);


            List<Bees> beeList1 = new List<Bees>();
            beeList1.Add(b1);
            beeList1.Add(b2);
            beeList1.Add(b3);
            beeList1.Add(b4);

            List<Bees> beeList2 = new List<Bees>();
            beeList2.Add(b5);
            beeList2.Add(b6);
            beeList2.Add(b7);

            Console.WriteLine("Hello World!");
        }
    }

    public class Bee {
        public string Name;
        public float Size;

        public Bee(string name, float size) {
            this.Name = name;
            this.Size = size;
        }
    
    }

    public class Hive {
        public int MaxBees;
        public List<Bee> Bees;

        public Hive(List<Bee> bees, int maxBees) {
            this.MaxBees = maxBees;
            this.Bees = bees;
        }


    }
}
