using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT

            int countOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double money = 0;
            double costs = 0;

            //LOGIC
            if (place == "Bulgaria")
            {
                money = points * countOfDancers;
            }
            else
            {

                money = (countOfDancers * points);
                money += money * 0.50;
            }

            if (season == "summer")
            {
                if (place == "Bulgaria")
                {
                    costs = money - (money * 0.05);

                }
                else
                {
                    costs = money - (money * 0.10);
                }
            }

            if (season == "winter")
            {
                if (place == "Bulgaria")
                {
                    costs = money - (money * 0.08);

                }
                else
                {
                    costs = money - (money - 0.15);
                }

            }

            double charity = costs * 0.75;
            double lastMoneyForTeams = costs - charity;
            double priceForPerson = lastMoneyForTeams / countOfDancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {priceForPerson:f2}");

        }
    }
}
