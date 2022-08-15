using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            //INPUT
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int countOfProccesors = int.Parse(Console.ReadLine());
            int countOfRam = int.Parse(Console.ReadLine());
            double discountVideoCard = 0;
            if (videoCards > countOfProccesors)
            {
                //countOfProccesors 15% discount
                discountVideoCard = countOfProccesors * 0.15;
               // double totalForVideoCard = videoCards * priceVideoCard;
            }

            //GIVEN


            double priceVideoCard = 250; 
            double totalForVideoCard = videoCards * priceVideoCard;
            double priceProccesor = 0.35 * totalForVideoCard;
            double priceRam = 0.10 * totalForVideoCard;

            
            double totalForProcessors = priceProccesor * countOfProccesors;
            double totaLForRam = priceRam * countOfRam;

            //LOGIC
            
            double totalPrice = totalForVideoCard+ totalForProcessors+ totaLForRam;
            if (budget > totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }

    }
}
