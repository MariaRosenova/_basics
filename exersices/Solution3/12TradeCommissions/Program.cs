using System;

namespace _12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //commission
            //Sofia   5 %   7 %   8 %   12 %
            //Varna   4.5  % 7.5  % 10  % 13 %
            //Plovdiv 5.5   % 8   % 12 % 14.5 %

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            switch (town)
            {
                case "Sofia":
                    if(sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales <= 500)
                    { //first
                        double commission = sales * 0.05;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (500 < sales && sales <= 1000) //500 < s ≤ 1 000
                    {   //second
                        double commission = sales * 0.07;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000) //500 < s ≤ 1 000
                    {   //third
                        double commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (sales > 10000) //500 < s ≤ 1 000
                    {   //fourth
                        double commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    break;
                   
                    
                // 5.5 / 100 x number 
                case "Plovdiv":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales <= 500)
                    {
                        //first
                        double commission = (5.5 /100)* sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (500 < sales && sales <= 1000) //500 < s ≤ 1 000
                    {   // second
                        double commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000) //500 < s ≤ 1 000
                    {   //third
                        double commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (sales > 10000) //500 < s ≤ 1 000
                    {   //fourth 14.5
                        double commission = (14.5/100)*sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                   
                    break;
                    case "Varna":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales <= 500)
                    { //first 4.5
                        double commission = (4.5/100)*sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (500 < sales && sales <= 1000) //500 < s ≤ 1 000
                    {   //second 8
                        double commission = (7.5/100)*sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (1000 < sales && sales <= 10000) //500 < s ≤ 1 000
                    {   //third 12
                        double commission = 0.10* sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                    else if (sales > 10000) //500 < s ≤ 1 000
                    {   //fourth 14.5
                        double commission = 0.13*sales;
                        Console.WriteLine($"{commission:f2}");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
          
        }
    }
}
