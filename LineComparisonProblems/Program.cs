using System;

namespace LineComarisonProblems
{
    // class
    class LengthOfLine
    {
        //declaring fields
        int x1, y1, x2, y2;

        //constructor
        public LengthOfLine(int X1, int Y1, int X2, int Y2)
        {
            this.x1 = X1;
            this.y1 = Y1;

            this.x2 = X2;
            this.y2 = Y2;
        }

        //method
        public double CalculateLengthOfLine()
        {
            int point1 = x2 - x1;
            int point2 = y2 - y1;
            Console.WriteLine("cordinates are x1,y1,x2,y2 {0} {1} {2} {3}", x1, y1, x2, y2);
            double total = Math.Sqrt((point1) + (point2));
            return total;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LengthOfLine p1 = new LengthOfLine(5, 5, 50, 50);
            double output1 = p1.CalculateLengthOfLine();
            double lenght1 = Math.Sqrt(output1);

            LengthOfLine p2 = new LengthOfLine(10, 10, 55, 100);
            double output2 = p2.CalculateLengthOfLine();
            double lenght2 = Math.Sqrt(output2);


            Console.WriteLine("Length of line1 of given 4 coordinates is  " + lenght1);
            Console.WriteLine("Length of line2 of given 4 coordinates is  " + lenght2);

            if (lenght1 == lenght2)
            {
                Console.WriteLine("Both Line lengths are equal ");

            }
            else if (lenght1 > lenght2)
            {
                Console.WriteLine("Length of Line1 is greater than Length of Line2");
            }
            else
            {
                Console.WriteLine("Length of Line1 is less than Length of Line2");
            }



        }
    }
}