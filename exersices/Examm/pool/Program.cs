using System;
using System.Threading;

namespace pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int countOfPeople = int.Parse(Console.ReadLine()); //75% искат шезлонги
            double entranceCharge = double.Parse(Console.ReadLine());
            double priceDeckChair = double.Parse(Console.ReadLine()); //ШЕЗЛОНГ
            double priceUmbrella = double.Parse(Console.ReadLine()); // ЧАДЪР 
            //LOGIC
            double totalCharge = countOfPeople * entranceCharge; //входна цена
            double peopleForDeckChair = Math.Ceiling(countOfPeople * 0.75); 
            double priceForDeckChairs = peopleForDeckChair * priceDeckChair; //цена за шезлонги
            double countOfPeopleForUmbrellas = Math.Ceiling(countOfPeople * 0.50);
            double priceForUmbrellas = countOfPeopleForUmbrellas * priceUmbrella;

            double totalPrice = priceForDeckChairs + priceForUmbrellas + totalCharge;
            Console.WriteLine($"{totalPrice:F2} lv.");

        }
    }
}
