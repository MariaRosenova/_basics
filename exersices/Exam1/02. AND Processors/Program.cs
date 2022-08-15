using System;

namespace _02._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
           
            int countOfProccesors = int.Parse(Console.ReadLine());
            int countOfЕmployees = int.Parse(Console.ReadLine());
            int countOfWorkDays = int.Parse(Console.ReadLine());

            //LOGIC
            //Планувани процесора
            int timeOfWorks = countOfЕmployees * countOfWorkDays * 8;
            double doneProccesors = Math.Floor(timeOfWorks*1.0 / 3); //за да получа колко са процесорите
            if(doneProccesors< countOfProccesors)
            {
                double lost = (countOfProccesors - doneProccesors)*110.10;
                Console.WriteLine($"Losses: -> {lost:f2} BGN");
            }
            else
            {
                
                double profit2 = ((countOfProccesors - doneProccesors) *110.10)/-1;
                Console.WriteLine($"Profit: -> {profit2:f2} BGN");
            }


        }
    }
}
