using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {

            //INPUT
            double income = double.Parse(Console.ReadLine());
            double avaregeSuc = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
           
            double socMoney = minSalary * 0.35; //за сравнение
            double sucMoney = avaregeSuc * 25;
            //LOGIC.
            if (income > minSalary || avaregeSuc < 4.50 || avaregeSuc < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minSalary && avaregeSuc > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socMoney)} BGN");
            }
            else if (avaregeSuc >5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(sucMoney)} BGN");
            }
            else if ((income < minSalary || avaregeSuc >= 5.50))
            {
                if(sucMoney>socMoney)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(sucMoney)} BGN");
                }
                else if(sucMoney == socMoney)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(sucMoney)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socMoney)} BGN");
                }
            }
            

        }
    }
}

