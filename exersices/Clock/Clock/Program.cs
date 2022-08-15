using System;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //трябва в този диапазон да изведем всички цифри , чиито четни и нечетни позиции са равни.
            //1.for в диапазон от [100000 - 300000]
            //1.1 трябва да има променлива на всяка итерация , която да присвоява числото от for 
            //1.2 for loop на всяко число да го мине цялото 
            //1.3 вътре в for loop if проверка , кое е четно и кое не е и да има един counter , който да ги присвоява според това , какво е числото
            //1.4 if еvenNum = oddNum --> Print . Else nothing 
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int check = 0;
            double evenNum1 = 0;
            double oddNum1 = 0;
            double evenNum2 = 0;
            double oddNum2 = 0;
            double safeEven1 = 0;
            double safeOdd1 = 0;
            double safeEven2 = 0;
            double safeOdd2 = 0;
            

            for (int i = 1; i <= num1.Length; i++)
            {
                

                for (int firstNumberLenght = 1; firstNumberLenght < num1.Length; firstNumberLenght++)
                {
                    if(firstNumberLenght%2==0)
                    {
                        evenNum1 += firstNumberLenght;
                        safeEven1 = firstNumberLenght;
                    }
                    else
                    {
                        oddNum1 += firstNumberLenght;
                        safeOdd1 = firstNumberLenght;
                    }
                    if(evenNum1!=0 && oddNum1!=0)
                    {
                        
                    }
                   
                }
            }
            for (int k = 1; k <= num2.Length; k++)
            {
               

                for (int secondNumberLenght = 1; secondNumberLenght < num2.Length; secondNumberLenght++)
                {
                    if (secondNumberLenght % 2 == 0)
                    {
                        evenNum2 += secondNumberLenght;
                        safeEven2 = secondNumberLenght;
                    }
                    else
                    {
                        oddNum2 += secondNumberLenght;
                        safeOdd2 = secondNumberLenght;
                    }
                }
            }
            if (evenNum2 == evenNum1 && oddNum2 == oddNum1)
            {
                Console.WriteLine(safeEven1);
                Console.WriteLine(safeOdd1);
                Console.WriteLine(safeEven2);
                Console.WriteLine(safeOdd2);
            }
        }
    }
}
