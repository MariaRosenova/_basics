using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum = 0; int oddSum = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currNum = i.ToString();

                for (int j = 0; j < currNum.Length; j++)
                { //минаваме като string през for и за да можем да работим с currNum го преобразуваме
                    int currDigit = int.Parse(currNum[j].ToString());

                    if (j%2==0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                    if (evenSum==oddSum)
                    {
                        Console.WriteLine(i + " ");
                    }
                    else
                    {
                        evenSum = 0;
                        oddSum = 0;
                    }
                }
            }
        }
    }
}
