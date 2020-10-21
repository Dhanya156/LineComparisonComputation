using System;

namespace LineComparisonComputation
{
    class Program
    {
        public static double line1 = 0, line2 = 0;
        static double LengthOfLine(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void CompareTwoLines(double line1, double line2)
        {
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("The two lines are equal");
            if(line1.CompareTo(line2) > 0)
                Console.WriteLine("The line1 is greater than line2");
            if (line1.CompareTo(line2) < 0)
                Console.WriteLine("The line1 is less than line2");
        }
        static void Main(string[] args)
        {
            line1 = LengthOfLine(2, 3, 3, 2);
            line2 = LengthOfLine(2, 3, 4, 2);
            CompareTwoLines(line1, line2);
        }
    }
}
