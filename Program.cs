using System;

namespace LineComparisonComputation
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Line
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }


        public double Length()
        {
            return Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            var line1 = new Line { P1 = new Point {X = 0, Y = 0 }, P2 = new Point {X=1, Y=1 } };
            var line2 = new Line { P1 = new Point { X = 0, Y = 0 }, P2 = new Point { X = -1, Y = -1 } };
            if (line1.Length().Equals(line2.Length()))
                Console.WriteLine("Lines are Equal");
            else
                Console.WriteLine(line1.Length().CompareTo(line2.Length() > 0  ? "Line 1 is Greater than Line 2" : "Line 2 is Greater than Line1"));
            

        }
    }
}
