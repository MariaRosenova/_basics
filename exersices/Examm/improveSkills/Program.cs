using System;
using System.Xml;

namespace improveSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += number;
                    if(number>evenMax)
                    {
                        evenMax = number;
                    }
                    if(number<evenMin)
                    {
                        evenMin = number;
                    }
                    else
                    {
                        oddSum += number;
                        if (number >oddMax)
                        {
                            oddMax = number;
                        }
                        if (number < oddMin)
                        {
                            oddMin = number; 
                        }
                    }
                }
                   
                Console.WriteLine($"OddSum=  + {oddSum}");
                if (oddSum ==0) //ако нямаме минимални стойности
                {
                    Console.WriteLine("OddMin=" + "No,");
                    Console.WriteLine("OddMax=" + "No");
                }
                else
                {
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMax);
                }
                Console.WriteLine($"EvenSum=  + {evenSum}");
                if (evenSum ==0)
                {
                    Console.WriteLine("EvenMin=" + "No,");
                    Console.WriteLine("EvenMax=" + "No");
                }
                else
                {
                    Console.WriteLine("OddMin=" + evenMin);
                    Console.WriteLine("OddMax=" + evenMax);
                }
            }
        }
    }
}
