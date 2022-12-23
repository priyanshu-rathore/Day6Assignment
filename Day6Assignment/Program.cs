

namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1). Fibonacci series  2). Perfect Number  3). Prime Number  4). Reverse a Number");
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


            }
        }
    }
}