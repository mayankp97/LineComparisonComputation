using System;

namespace LineComparisonComputation
{
    class Line
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public double Length()
        {
            return Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            var line1 = new Line { X1 = 0, X2 = 0, Y1 = 1, Y2 = 1 };
            var line2 = new Line { X1 = 0, X2 = 0, Y1 = -1, Y2 = -1 };
            Console.WriteLine(line1.Equals(line2) ? "Lines are Equal" : "Lines are Not Equal");

        }
    }
}
