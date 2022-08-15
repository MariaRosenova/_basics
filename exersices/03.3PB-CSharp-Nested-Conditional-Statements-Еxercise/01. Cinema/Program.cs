using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // •Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.


            string typeProjection = Console.ReadLine();
            int countOfRows = int.Parse(Console.ReadLine());
            int countOfColums = int.Parse(Console.ReadLine());
            double priceTicket = 0;
            

            switch (typeProjection)
            {
                case "Premiere":
                    priceTicket = 12.00;
                    break;
                case "Normal":
                    priceTicket = 7.50;
                    break;
                case "Discount":
                    priceTicket = 5.00;
                    break;
            }
            double income = countOfColums * countOfRows * priceTicket;
            Console.WriteLine($"{income:F2} leva");

        }
    }
}
