using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            //6	Excellent!5	(няма изход)	5.50	Excellent!	5.49	(няма изход)
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");

            }
        }
    }
}