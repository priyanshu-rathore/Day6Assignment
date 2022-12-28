using System;

namespace Day6Assignment
{
    class toDecimal
    {
        public static double ToDecimal(int input)
        {
            double decimalValue = 0;
            int count = 0;
            while (input > 0)
            {
                int power = input % 10;
                decimalValue += Math.Pow(2, count) * power;
                input = input / 10;
                count++;
            }

            return decimalValue;
        }

        public static void Decimal(){
            System.Console.WriteLine("Enter the Binary number");
            int input = Convert.ToInt32(Console.ReadLine());

            double Decimal = ToDecimal(input);

            System.Console.WriteLine(Decimal);
        }
    }
}