using System;

namespace Day6Assignment
{
    class VendingMachine
    {
        public static void change()
        {
            System.Console.Write("Enter Note : ");
            double n = Convert.ToDouble(Console.ReadLine());

            double note = n;
            double m =0;

            // int[] Notes = new int[] { 1, 2, 5, 10, 50, 100, 500, 1000 };

            while (n > 0)
            {
                if (note > 1000)
                {
                    n = n / 1000;
                    m=n;
                    System.Console.WriteLine($"1000 x {(int)m} note");
                    n *= 1000;
                    n -= 1000;
                    note = n;
                }

                if (note < 1000 && note >= 500)
                {
                    n /= 500;
                    m=n;
                    System.Console.WriteLine($"500 x {(int)m} note");
                    n = note;
                    n -= 500;
                    note = n;                             
                }
                if (note < 500 && note > 100)
                {
                    n /= 100;
                    m=n;
                    System.Console.WriteLine($"100 x {(int)m} note");
                    n *= 100;
                    n %= 100;
                    note = n;
                }
                if (note < 100 && note >= 50)
                {
                    n /= 50;
                    m=n;
                    System.Console.WriteLine($"50 x {(int)m} note");
                    n = note;
                    n -=50;
                    note = n;
                }
                if (note < 50 && note >= 10)
                {
                    n /= 10;
                    m=n;
                    System.Console.WriteLine($"10 x {(int)m} note");
                    n *= 10;
                    n %= 10;
                    note = n;
                }
                if (note < 10 && note >= 1)
                {

                    System.Console.WriteLine($"1 x {(int)n} coin");
                    n = 0;
                }

            }

        }
    }
}
