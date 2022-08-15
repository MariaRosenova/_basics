using System;
using System.Text;

namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int meterMm = 1000; //mm 1000
            int meterM = 100; //cm;
            double operation = 0.0;

            double firstNumber = double.Parse(Console.ReadLine());
            string unitEnterence = Console.ReadLine(); //merni edinici
            string unitExit = Console.ReadLine();
            if (unitEnterence == "cm" && unitExit == "mm")
            {
                operation = firstNumber * 10;
                Console.WriteLine($"{operation:f3}");
            }
            else if(unitEnterence == "mm" && unitExit == "cm")
            {
                operation = firstNumber / 10;
                Console.WriteLine($"{operation:f3}");
            }
            else if (unitEnterence == "m" && unitExit == "cm")
            {
                operation = firstNumber * 100;
                Console.WriteLine($"{operation:f3}");
            }
            else if (unitEnterence == "cm" && unitExit == "m")
            {
                operation = firstNumber / 100;
                Console.WriteLine($"{operation:f3}");
            }
            else if (unitEnterence == "mm" && unitExit == "m")
            {
                operation = firstNumber / 1000;
                Console.WriteLine($"{operation:f3}");
            }
            else if (unitEnterence == "m" && unitExit == "mm")
            {
                operation = firstNumber * 1000;
                Console.WriteLine($"{operation:f3}");
            }


        }
        
    }
}
