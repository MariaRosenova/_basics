using System;
using System.Runtime.InteropServices;

namespace preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int oddNumbers = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                
                string curDigit = i.ToString();

                for (int j = 0; j < curDigit.Length; j++)
                {
                   
                 int mainNum = int.Parse(curDigit[j].ToString());
                
                   if(mainNum%2!=0)
                    {
                        oddNumbers += mainNum;
                    }
                   else
                    {
                        oddNumbers = 0;
                    }
                }
                if (oddNumbers != 0)
                {
                    Console.WriteLine(curDigit);
                }
            }
            }
        }
    }

