using System;

namespace Day6Assignment{
    class PrimeNumber{
        public static void primeNumber(){
            System.Console.Write("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1;i<n;i++){
                if(n%i==0){
                    count++;
                }
            }

            if(count>1){
                System.Console.WriteLine($"{n} is a not a Prime Number");
            }else{
                System.Console.WriteLine($"{n} is a Prime Number");
            }
        }
    }
}