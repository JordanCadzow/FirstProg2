using System;
using System.Collections.Generic;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die();
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList1 = new List<Die>();
            diceList1.Add(d1);
            diceList1.Add(d2);
            //diceList1.Add(d3);

            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);

            Person p1 = new Person("Willam Wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Dice.Count);

            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p2.Dice.Count);
            p2.AddNewDie(18);
            System.Console.WriteLine(p2.Dice.Count);

            for(int i = 0; i < 5; i++) {
                System.Console.WriteLine(p1.RollAllDice());

            }


        }
    }

    public class Die {
        public int NumSides;

        public Die(int numsides) {
            this.NumSides = numsides;

        }

        public Die() {
            this.NumSides = 6;
        }

        public int Roll() {
            Random rand = new Random();
            int roll = rand.Next(1, this.NumSides+1);
            
            return roll;
        }

    }

    public class Person {
        public string Name;
        public List<Die> Dice;

        public Person(string name, List<Die> dice) {
            this.Name = name;
            this.Dice = dice;
        }

        public Person() {
            this.Name = "John Doe";
            this.Dice = new List<Die>();
        }
            


        public int RollDie(int die) {
            int roll = -1;
            if(die > 0 && die < Dice.Count) {
                roll = Dice[die].Roll();
            }
            return roll; 
        }

        public int RollAllDice() {
            int totalRoll = 0;
            for(int i = 0; i < Dice.Count; i++)
            {
                int roll = Dice[i].Roll();
                totalRoll = totalRoll + roll;
            }
            
            return totalRoll;
        }

        public void AddNewDie(int sides) {
            Die d = new Die(sides);
            this.Dice.Add(d);
        }

    }

}
