using System;

namespace LastExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT

            double priceForProcessorinDollars = double.Parse(Console.ReadLine());//цена за процесор
            double priceForVideoCardInDollars = double.Parse(Console.ReadLine()); //цена за видеоКард           
            double priceForRAM = double.Parse(Console.ReadLine()); //ЦЕНА ЗА RAM
            int countOfRAM = int.Parse(Console.ReadLine()); //броя пакети RAM
            double discount = double.Parse(Console.ReadLine()); //ОТСТЪПКА

            //LOGIC
            //Трябва да имаме в предвид , че той има лева ,а трябва да се преобърне в долари
            double priceForProcessor = 1.57 * priceForProcessorinDollars; //cena v leva
            double priceForVideoCard = 1.57 * priceForVideoCardInDollars;
            double priceForRam = 1.57 * priceForRAM;
            double totalRAM = (countOfRAM*1.0) * priceForRam;
            double priceWithDiscountForProcessor = priceForProcessor - (discount * priceForProcessor);
            double priceWithDiscountForVideoCard = priceForVideoCard - (discount * priceForVideoCard);
            double totalPrice = priceWithDiscountForProcessor + priceWithDiscountForVideoCard + totalRAM;

            //"Money needed - {общо лева} leva."
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
