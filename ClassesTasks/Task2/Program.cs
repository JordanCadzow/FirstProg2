using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Sam", "Newton", "16/06/1996", 183);
            Person p2 = new Person("Jordan", "Cadzow", "29/05/2001", 180);
            Person p3 = new Person("Killmaim", "Deathstab", "1/01/2020", 143);

            Console.WriteLine(p1.GetFullName());
            Console.WriteLine(p2.GetFullName());
            Console.WriteLine(p3.GetFullName());

            Console.WriteLine(p1.GetHeightDifference(p2));
            Console.WriteLine(p1.GetHeightDifference(p3));
            Console.WriteLine(p2.GetHeightDifference(p3));

            
        }
    }
    
    public class Person {
        public string Firstname;
        public string Surname;
        public string Dob;
        public int Height;
        public int Id;
        public List<Subject> Subjects;


        public Person(string fname, string sname, string dob, int height) {
            this.Firstname = fname;
            this.Surname = sname;
            this.Dob = dob;
            this.Height = height;
            Random rand = new Random();
            this.Id = rand.Next(1000, 9999);
        }

        public string GetFullName() {
            return this.Firstname + " " + this.Surname;
        }

        public int GetHeightDifference(Person other) {
            if (this.Height > other.Height) {
                return this.Height - other.Height;
            }
            else {
                return other.Height - this.Height;
            }
        }

        public void AddNewSubject(string Name, int YearOfDelivery) {
            Subject subject = new Subject(Name, YearOfDelivery, "TBD");
            this.Subjects.Add(subject);
        }

    }
    public class Subject {
        public string Name;
        public int YearOfDelivery;
        public string Grade;

        public Subject(string name, int yearofdelivery, string grade) {
            this.Name = name;
            this.YearOfDelivery = yearofdelivery;
            this.Grade = grade;
        }

    }
}
