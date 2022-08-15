using System;

namespace _06GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Сума за декор: 10 % от 15437.62 = 1543.762 лв.
            //Сума за облекло: 186 * 57.99 = 10786.14 лв.
            //Статистите са повече от 150 следователно има 10 % отстъпка на облеклото.
            //10 % от 10786.14 е 1078.614
            //10786.14 – 1078.614 = 9707.526 лв.за облекло
            //Обща сума за филма: 1543.762 + 9707.526 = 11251.288
            //15437.62 – 11251.288 = 4186.331 лева остават



            double budget = double.Parse(Console.ReadLine());
            int countOfExtras = int.Parse(Console.ReadLine()); //статисти
            double pricePerClothe = double.Parse(Console.ReadLine());
            double decor = budget * 0.10; //декор
            double totalForClothes = pricePerClothe * countOfExtras; //облекло 
            double priceForEverything = 0;

            if (countOfExtras >= 150)
            {
                double discount = totalForClothes * 0.10;

                priceForEverything = decor + (totalForClothes - discount);

            }
            else
                priceForEverything = decor + totalForClothes;

            if (budget - priceForEverything < 0)
            {
                double needMoney = priceForEverything - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");


            }
            else
            {
                double moreMoney = budget - priceForEverything;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moreMoney:f2} leva left.");





            }


        }
    }
}
