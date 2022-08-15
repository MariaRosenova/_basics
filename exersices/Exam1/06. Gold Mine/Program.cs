using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            // 1.На първия ред – очакван среден добив на ден злато – реално число в интервала[0.00..10000.00]
            double expectedЕxtraction = double.Parse(Console.ReadLine());
            int countOfDaysOfLocation = int.Parse(Console.ReadLine());
            //2.На втория ред – брой дни, в който ще се копае на дадената локация – цяло число в интервала[1..30]
            //За всеки ден се чете по едно число:
            double total = 0;
            for (int i =1; i>= countOfDaysOfLocation; i++)
            {
                
                double extractionForDayNum = double.Parse(Console.ReadLine());
                total += extractionForDayNum;


            }
            double avarageExtraction = (total*1.0) / countOfDaysOfLocation;
            if(expectedЕxtraction<avarageExtraction)
            {
                double profit = avarageExtraction - expectedЕxtraction;
                Console.WriteLine($"Good job! Average gold per day: {profit:f2}.");
            }
            //•	Добито злато за деня – реално число в интервала[0.00..1000.00]

        }
    }
}
