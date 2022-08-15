using System;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double priceForVacation = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dows = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());
            double profit = 0; double rent = 0;
            double pricePuzzle = 2.60 * puzzles; double priceDow = 3 * dows; double priceBears = 4.10 * bears; double priceMinion = 8.20 * minions; double priceTrack = 2 * tracks;
            //LOGICAL

            double priceToys = pricePuzzle + priceDow + priceBears + priceMinion + priceTrack;
            double totalToys = puzzles + dows + bears + minions + tracks;
            if (totalToys >= 50)
            {
                double discount = priceToys * 0.25;

                profit = priceToys - discount;
                rent = profit * 0.10;
                profit -= rent;


            }
            else
            {
                rent = priceToys * 0.10;
                profit = priceToys - rent;
            }
            if (profit >= priceForVacation)
            {
                double moneyLeft = profit - priceForVacation;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else 
            {
                double moneyNeeded = priceForVacation-profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

        }

    }
}

