using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double record = double.Parse(Console.ReadLine()); 
            double distance = double.Parse(Console.ReadLine()); 
            double timeForMin = double.Parse(Console.ReadLine());

            double speed = distance * timeForMin; 
        
            double withResistance = Math.Floor(distance / 15) * 12.5; 
            double totalTime = speed + withResistance;
            

            if (record <  totalTime)
            {
                double needTime = totalTime-record;
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
            else
            {
                double rightTime = (speed + withResistance);
                
                Console.WriteLine($"Yes, he succeeded! The new world record is {rightTime:f2} seconds.");
            }

            
        }
    }
}
