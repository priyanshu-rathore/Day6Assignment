using System;

namespace Day6Assignment{
    class toBinary{
        public static string ToBinary(int input)
        {
            string binary = string.Empty;
            while (input > 0)
            {
                int addBinary = input % 2;
                binary = addBinary + string.Empty + binary;
                input = input / 2;
            }

            return binary;
        }

        public static void Binary(){
            System.Console.WriteLine("Enter the decimal");
            int input = Convert.ToInt32(Console.ReadLine());

            string binary = ToBinary(input);

            System.Console.WriteLine(binary);

        }
    }
}