using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60; //когато искаме да извадим минутите от total
            int seconds = totalTime % 60; //а секундите се вадят като остатък
            if (seconds <10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else

                Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}
