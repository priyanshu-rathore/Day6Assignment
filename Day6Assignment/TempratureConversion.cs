using System;

namespace Day6Assignment
{
    class TempratureConversion
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static void TempConversion(){
            System.Console.WriteLine("Enter celsius");
            var celsius = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter fahrenheit");
            var Farhen = Convert.ToDouble(Console.ReadLine());

            var CelToFar = CelsiusToFahrenheit(celsius);
            var FarToCel = FahrenheitToCelsius(Farhen);

            System.Console.WriteLine($"{celsius} celsius equal to {CelToFar} Fahrenheit");
            System.Console.WriteLine($"{Farhen} Fahrenheit equal to {FarToCel} Celsius");
        }
    }
}