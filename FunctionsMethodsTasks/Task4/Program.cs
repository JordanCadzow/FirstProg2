using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string:");
            string sentence = Console.ReadLine();
            Program prgrm = new Program();
            Console.WriteLine(prgrm.Spaces(sentence));
        }

        public string Spaces(string Sentence) {
            int spaces = Sentence.Split(' ').Length - 1;
            return "'" + Sentence + "'" + " contains " + spaces + " space(s)";

        }
    }
}
