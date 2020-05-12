using System;
using System.Collections.Generic;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string toAdd = "";
            while (toAdd != "stop") {
                toAdd = Console.ReadLine();
                words.Add(toAdd);
            }
            for(int i = 2; i <= words.Count; i++ ) {
                int pos = words.Count-i;
                Console.WriteLine(words[pos]);
            }
        }
    }
}
