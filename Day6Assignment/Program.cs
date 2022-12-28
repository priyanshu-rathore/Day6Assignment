using System;
using System.Diagnostics;

namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            Console.WriteLine("1). Fibonacci series  2). Perfect Number  3). Prime Number  4). Reverse a Number  5). Coupon Numbers");
            System.Console.WriteLine("6). Vending Machine 7). Days of week  8). Temprature Conversion  9). Monthly payment  10).Sqaure roots");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci.fibonacci();
                    break;
                case 2:
                    PerfectNumber.perfectNumber();
                    break;
                case 3:
                    PrimeNumber.primeNumber();
                    break;
                case 4:
                    Reverse.reverse();
                    break;
                case 5:
                    CouponNumbers.couponNumbers();
                    break;
                case 6:
                    VendingMachine.change();
                    break;
                case 7:
                    DayOfWeek.Days();
                    break;
                case 8:
                    TempratureConversion.TempConversion();
                    break;
                case 9:
                    MonthlyPayments.monPay();
                    break;
                case 10:
                    sqrt.sqrts();
                    break;


            }

            stopWatch.Stop();

            int time = (int)stopWatch.ElapsedMilliseconds;

            System.Console.WriteLine($"Elaspsed time is {time}");
        }
    }
}