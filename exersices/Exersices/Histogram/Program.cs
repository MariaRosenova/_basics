using System;
using System.Security.Cryptography;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counterStepsP1= 0;
            int counterStepsP2= 0;
            int counterStepsP3= 0;
            int counterStepsP4= 0;
            int counterStepsP5= 0;
            int p1Counter = 0; 
            int p2Counter = 0; 
            int p3Counter = 0; 
            int p4Counter = 0; 
            int p5Counter = 0;

            int numbers = int.Parse(Console.ReadLine());
            for (int i=1; i<=numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num<200)
                {
                    counterStepsP1++;
                    p1Counter += num;
                }
                else if(num>=200 && num<=399)
                {
                    counterStepsP2++;
                    p2Counter += num;
                }
                else if(num>=400 && num<=599)
                {
                    counterStepsP3++;
                    p3Counter += num;
                }
                else if(num>=600 && num<=799)
                {
                    counterStepsP4++;
                    p4Counter += num;
                }
                else
                {
                    counterStepsP5++;
                    p5Counter += num;
                }
            }
            //percents         
            double percentP1 = (counterStepsP1*1.0) / numbers * 100;
            double percentP2 = (counterStepsP2*1.0) / numbers * 100;
            double percentP3 = (counterStepsP3*1.0) / numbers * 100;
            double percentP4 = (counterStepsP4*1.0) / numbers * 100;
            double percentP5 = (counterStepsP5*1.0) / numbers * 100;
                               
            Console.WriteLine($"{ percentP1:f2}%");
            Console.WriteLine($"{ percentP2:f2}%");
            Console.WriteLine($"{ percentP3:f2}%");
            Console.WriteLine($"{ percentP4:f2}%");
            Console.WriteLine($"{ percentP5:f2}%");

        }
    }
}
