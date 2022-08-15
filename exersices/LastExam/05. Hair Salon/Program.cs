using System;

namespace _05._Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {

            double price = 0;
            double money = 0;
            int goal = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "closed")
            {

                string type = Console.ReadLine();
                if (type == "haircut")
                {
                    if (type == "mens")
                    {
                        price = 15;

                    }
                    else if (type == "ladies")
                    {
                        price = 20;

                    }
                    else if (type == "kids")
                    {
                        price = 10;

                    }
                    money += price;
                }
                else if (type == "color")
                {
                    if (type == "touch up")
                    {
                        price = 20;

                    }
                    else if (type == "full color")
                     {
                        price = 30;

                    }
                }
                money += price;

            }
            if (money >= goal)
            {
                double earnedMoney = money;
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {earnedMoney:f2}lv.");
            }
            else
            {
                double needMoney = goal - money;
                double earnedMoney = money;
                Console.WriteLine($"Target not reached! You need {needMoney:f2}lv. more.");
                Console.WriteLine($"Earned money: {earnedMoney:f2}lv.");

            }


        }
    }
}
