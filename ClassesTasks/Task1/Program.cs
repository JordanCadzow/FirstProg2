using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie Cookie1 = new Cookie();
            Cookie1.Weight = 5;
            Cookie1.Shape = "Square";
            Cookie1.colour.Red = 255;
            Cookie1.colour.Blue = 255;
            Cookie1.colour.Green = 255;
            Cookie1.colour.Name = "White";

            Cookie Cookie2 = new Cookie();
            Cookie2.Weight = 5;
            Cookie2.Shape = "Circle";
            Cookie2.colour.Red = 0;
            Cookie2.colour.Blue = 0;
            Cookie2.colour.Green = 0;
            Cookie2.colour.Name = "Black";

            Cookie Cookie3 = new Cookie();
            Cookie3.Weight = 10;
            Cookie3.Shape = "Square";
            Cookie3.colour.Red = 0;
            Cookie3.colour.Blue = 0;
            Cookie3.colour.Green = 0;
            Cookie3.colour.Name = "Black";

            Cookie Cookie4 = new Cookie();
            Cookie4.Weight = 10;
            Cookie4.Shape = "Circle";
            Cookie4.colour.Red = 255;
            Cookie4.colour.Blue = 255;
            Cookie4.colour.Green = 255;
            Cookie4.colour.Name = "White";


            Console.WriteLine(Cookie1.Weight);
            Console.WriteLine(Cookie1.Shape);
            Console.WriteLine(Cookie1.colour.Name);

        }
    
    }
    public class Cookie {
        public int Weight;
        public string Shape;
        public Colour colour = new Colour();

        // To instantiate a cookie: Cookie (cookiename) = new Cookie();
    }
    public class Colour {
        public int Red;
        public int Blue;
        public int Green;
        public string Name;
    }
}
