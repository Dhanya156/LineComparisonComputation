using System;

namespace LineComparisonComputation
{
    class Program
    {
        static double LengthOfLine(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLine(2, 3, 3, 4));
        }
    }
}
