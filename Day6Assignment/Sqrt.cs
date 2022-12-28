using System;

namespace Day6Assignment
{
    class sqrt
    {
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                return double.NaN;
            }

            double t = c;

            
            t = ((c / t) + t) / 2.0;
            return t;
        }

        public static void sqrts(){
         Console.WriteLine("Enter input for Square Roots:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Approx Square Root:" +Sqrt(input));   
        }
    }
}