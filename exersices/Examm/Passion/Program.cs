using System;

namespace Passion
{
    class Program
    {
        static void Main(string[] args)
        {
            //even - четно , odd - нечетно
            //сумата, минимума и максимума на числата на четни и нечетни позиции
            double evenSum = 0;
            double oddSum = 0;
            double evenMax = double.MinValue; double evenMin = double.MaxValue;
            double oddMax = double.MinValue; double oddMin = double.MaxValue;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                    else
                    {
                        evenMin = currentNum;
                    }


                }
                else
                {
                    oddSum += currentNum;

                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;

                    }
                    else
                    {
                        oddMin = currentNum;
                    }
                }
                if (currentNum == 0)
                {
                    Console.WriteLine("OddSum=0.00");
                    Console.WriteLine("OddMin =No");
                    Console.WriteLine("OddMax =No");
                    Console.WriteLine("EvenSum=0.00");
                    Console.WriteLine("EvenMin =No");
                    Console.WriteLine("EvenMax =No");

                    //EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
                    //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
                }
                else
                {
                    Console.WriteLine($"OddSum=   { oddSum}");
                    Console.WriteLine($"OddMin=   { oddMin}");
                    Console.WriteLine($"OddMax=   { oddMax}");
                    Console.WriteLine($"EvenSum=   { oddMax}");
                    Console.WriteLine($"EvenMin=   { oddMax}");
                    Console.WriteLine($"EvenMax=   { oddMax}");



                }
            }
        }
    }
}
