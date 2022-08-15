using System;
using System.Runtime.InteropServices.ComTypes;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int totalFood = 0;
            // •Закупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            int food = int.Parse(Console.ReadLine());
            int mg = food * 1000;
            string grams = Console.ReadLine();
            while (grams!= "Adopted")
            {
              
                int gramsC = int.Parse(grams);

                    totalFood += gramsC;
                
                grams = Console.ReadLine();
                if (grams == "Adopted")
                {
                    break;
                }

            }
            if (totalFood<=mg )
            {
                
                Console.WriteLine($"Food is enough! Leftovers: {mg - totalFood} grams.");
            }
            else
            {
                int neededFood = totalFood - mg;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
            

        }
    }
}
