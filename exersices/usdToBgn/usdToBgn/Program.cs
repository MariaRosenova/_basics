using System;
using System.Diagnostics.CodeAnalysis;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //INPUT
            int numberOfPage = int.Parse(Console.ReadLine());
            double PageForHour = double.Parse(Console.ReadLine());
            int numberOfDaysForRead = int.Parse(Console.ReadLine());

            //Logic
            
            double SumTimeForRead = numberOfPage / PageForHour;
            double NeedTime = SumTimeForRead / numberOfDaysForRead;
            Console.WriteLine(NeedTime);
            //nie tursim kolko vreme shte e nujno za procchitane

        } 
    } 
}
