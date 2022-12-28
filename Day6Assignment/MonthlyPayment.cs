using System;

namespace Day6Assignment
{
    class MonthlyPayments
    {
        public static double MonthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double result = r / (12 * 100);

            return (p * result) / (1 - Math.Pow(1 + r, -n));
        }

        public static void monPay()
        {
            System.Console.WriteLine("Enter Principal Loan");
            double principalLoan = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter year");

            double year = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter Intrest rate");

            double percentInterest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Monthly Payments: " + MonthlyPayment(principalLoan, year, percentInterest));
        }
    }
}
