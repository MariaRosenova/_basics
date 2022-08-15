using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double income = double.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());
            double minimalSalary= double.Parse(Console.ReadLine());
            double money , moneyForScholarship, free2,free3= 0;
            // LOGIC 
            if (avarageGrade >=4.50 && avarageGrade<=5.49)
            {
                money = minimalSalary * 0.35;
                Console.WriteLine($"You get a Social scholarship {money} BGN");
            }
             if (avarageGrade>=5.50)
            {
                if(income <minimalSalary)
                {
                    money = minimalSalary * 0.35;
                   
                    Console.WriteLine($"You get a Social scholarship {money} BGN"); money = free2;
                }
                else if (income < minimalSalary)
                {
                    moneyForScholarship = avarageGrade*25;
                    Console.WriteLine($"You get a scholarship for excellent results {moneyForScholarship} BGN");
                    moneyForScholarship = free3;

                }
                if(free2 >free3)
                {

                }

            }
            //2. Правим втора проверка за успеха дали този път е над или 5,50
            //2.1 правим вътрешна проверка дали доходът е па - малък за член от сем
            //2.2 ако е по - малък -> 5% от минималната работна заплата 
            //2.3 успехът го умножаваме по 25 
            //2.4 правим последна проверка , кое като стойност е повече , ако дохода е малък и взимаме повечето.


        }

    }
    }

