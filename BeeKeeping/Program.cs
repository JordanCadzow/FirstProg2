using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {

            Bee b1 = new Bee("John", 3.2);
            Bee b2 = new Bee("Paul", 2.7);
            Bee b3 = new Bee("George", 1.1);
            Bee b4 = new Bee("Ringo", 2.0);

            Bee b5 = new Bee("Kurt", 2.3);
            Bee b6 = new Bee("Dave", 7.4);
            Bee b7 = new Bee("Krist", 1.5);


            List<Bee> beeList1 = new List<Bee>();
            beeList1.Add(b1);
            beeList1.Add(b2);
            beeList1.Add(b3);
            beeList1.Add(b4);

            List<Bee> beeList2 = new List<Bee>();
            beeList2.Add(b5);
            beeList2.Add(b6);
            beeList2.Add(b7);

            Hive h1 = new Hive(beeList1, 4);
            Hive h2 = new Hive(beeList2, 3);

            Console.WriteLine("Collecting last 4 days honey from Hive 1:");
            Console.WriteLine(h1.Honey(h1.Bees, 4));
            Console.WriteLine("Collecting last 4 days of honey from Hive 2:");
            Console.WriteLine(h2.Honey(h2.Bees, 4));

        
        }
    }

    public class Bee {
        public string Name;
        public double Size;

        public Bee(string name, double size) {
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

        public double Honey(List<Bee> bees, int days) {
            double totalHoney = 0.0;
            
            for (int i = 0; i < bees.Count; i++) {
                totalHoney = totalHoney + (bees[i].Size * 0.2);

            }
            return totalHoney;
        }


    }
}
