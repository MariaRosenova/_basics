using System;
using System.Buffers;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //  •	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]

            string typeFlowers = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceForFlowers = 0;
            double finalPrice = 0;
            
            switch(typeFlowers)
            {
                case "Roses":
                    priceForFlowers = 5;
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                    if(countFlowers>80)
                    {
                        finalPrice -= countFlowers * priceForFlowers * 0.10;
                    }
                    finalPrice += countFlowers * priceForFlowers;
                case "Dahlias":
                    priceForFlowers = 3.80;
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                    if (countFlowers > 90)
                    {
                        finalPrice -= countFlowers * priceForFlowers * 0.15;
                    }
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                case "Tulips":
                    priceForFlowers = 2.20;
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                    if (countFlowers > 80)
                    {
                        finalPrice -= countFlowers * priceForFlowers * 0.15;
                    }
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                case "Narcissus":
                    priceForFlowers = 3;
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                    if (countFlowers > 120)
                    {
                        finalPrice -= countFlowers * priceForFlowers * 0.15;
                    }
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                   case "Gladiolus":
                    priceForFlowers = 2.50;
                    finalPrice += countFlowers * priceForFlowers;
                    break;
                    if (countFlowers > 80)
                    {
                        finalPrice -= countFlowers * priceForFlowers * 0.20;
                    }
                    finalPrice += countFlowers * priceForFlowers;
                    break;
            }
            if (budget>=finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with { countFlowers} {typeFlowers} and {budget - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
            }
        }
    }
}
