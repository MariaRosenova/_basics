using System;

namespace _13SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            // "room for one person" – 18.00 лв за нощувка
            //	"apartment" – 25.00 лв за нощувка
            //	"president apartment" – 35.00 лв за нощувка

            double price = 0.0;
            int countDaysInHotel = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string feedback = Console.ReadLine();// positive or negative
            // BODY
            switch (typeRoom)
            {
                case "room for one person":
                    break;
                case "apartment":
                    if (countDaysInHotel <= 10)
                    {
                        //double roomForOnePerson = 18.00;
                        price = (18.00 * countDaysInHotel) * 0.30;
                        price -= price; Console.WriteLine(price);
                    }
                    break;
                    //dovurshi
            }
        }
    }
}
