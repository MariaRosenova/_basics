using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double exit = number * inch;
            Console.WriteLine(exit);

        }
    }
}
