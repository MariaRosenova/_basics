using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            //1.Цена на моминското парти - реално число в интервала[1.00 … 10000.00]
            //2.Брой любовни послания -цяло число в интервала[0… 1000]
            //3.Брой восъчни рози -цяло число в интервала[0 … 1000]
            //4.Брой ключодържатели - цяло число в интервала[0 … 1000]
            //5.Брой карикатури - цяло число в интервала[0 … 1000]
            //6.Брой късмети изненада -цяло число в интервала[0 … 1000]

            double priceForParty = double.Parse(Console.ReadLine());
            int lovePoslaniq = int.Parse(Console.ReadLine()); //любовни послания
            int vosukRozi = int.Parse(Console.ReadLine());//восъчни рози
            int kluchodurjateli = int.Parse(Console.ReadLine());//ключодържатели
            int karikatura = int.Parse(Console.ReadLine());//карикатури
            int countOfSuprices = int.Parse(Console.ReadLine());//Брой късмети изненада
            double price = 0;
            double countOfArt = lovePoslaniq + vosukRozi + kluchodurjateli + karikatura + countOfSuprices;
            double totalArt = ((lovePoslaniq*1.0)* 0.60) + ((vosukRozi*1.0)* 7.20 )+ ((kluchodurjateli*1.0)*3.60) + ((karikatura*1.0) *18.20 )+ ((countOfSuprices*1.0)*22);
            if (countOfArt>=25)
            {
                price = totalArt-(totalArt * 0.35);
                //discount 25% of totalPrice;
            }
            else
            {
                price = totalArt;
            }
            //-10% for hos
            double priceForHosting = price * 0.10;
            double totalPrice = price - priceForHosting;
            if (priceForParty<=totalPrice)
            {
                double leftMoney = totalPrice - priceForParty;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double moneyNeeded = priceForParty - totalPrice;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
