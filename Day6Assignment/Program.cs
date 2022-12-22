namespace Day6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1). Fibonacci series  2). Perfect Number");
            int option = Convert.ToInt32(Console.ReadLine());   

            switch(option)
            {
                case 1:Fibonacci.fibonacci();
                    break;
                case 2:PerfectNumber.perfectNumber(); 
                    break;


            }
        }
    }
}