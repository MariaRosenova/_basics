using System;

namespace _03._Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT

            // •На първия ред - месецът - текст с възможности: "march", "april", "may", "june", "july", "august"
            //•	На втория ред - броят на прекараните часове - цяло число в диапазона[1...10]
            //•	На третия ред - броят на хората в групата -цяло число в диапазона[1...10]
            //•	На четвъртия ред - времето от деня – текст с възможности: "day" или "night"
            string month = Console.ReadLine();
            int spentHours = int.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            //double priceWithDis = 0;
            double price =0;
            double finalPrice = 0;
            double finalPricePerHour = 0;
            double totalDiscount = 0;
            
            if(month== "march" || month == "april" || month == "may")
            {
                if(partOfDay== "day")
                {
                    price = 10.50;
                    if(countOfPeople>=4)
                    {
                        finalPrice = price * 0.10;
                        Console.WriteLine($"Price per person for one hour: {price}");
                        Console.WriteLine($"Total cost of the visit: {totalDiscount * countOfPeople}");
                    }
                    
                    else if(spentHours>= 5)
                    {
                        finalPricePerHour = price * 0.50;
                        Console.WriteLine($"Price per person for one hour: {price}");
                        Console.WriteLine($"Total cost of the visit: {totalDiscount * countOfPeople}");
                    }
                 
                    else if (countOfPeople >= 4 && spentHours >= 5)
                    {
                        totalDiscount = finalPrice - finalPricePerHour;
                        Console.WriteLine($"Price per person for one hour: {price}");
                        Console.WriteLine($"Total cost of the visit: {totalDiscount*countOfPeople}");
                    }
                  
                }
            }

            //double price = 0;
            
            //double finalPrice = 0;
            //switch (month)
            //{
            //    case "march":
            //    case "april":
            //    case "may":
            //        if (partOfDay == "day")
            //        {
            //            if (countOfPeople >= 4)
            //            {
            //                price = 10.50;
            //                finalPrice = price * 0.10;
                            
            //            }
            //            else
            //            {
            //                price = 10.50;
            //                finalPrice = price * countOfPeople;
                            

            //            }
            //            if (spentHours >= 5)
            //            {
            //                finalPrice = priceWithDis * 0.50;
                          
            //            }
            //            Console.WriteLine($"Price per person for one hour: {price:f2}");
            //            Console.WriteLine($"Total cost of the visit: {finalPrice* countOfPeople:f2}");
            //        }
            //        else if (partOfDay == "night")
            //        {
            //            if (countOfPeople >= 4)
            //            {
            //                price = 8.40;
            //                finalPrice = price * 0.10;
                            

            //            }
            //            else
            //            {
            //                price = 8.40;
            //                finalPrice = price * countOfPeople;
                            
            //            }
            //            if (spentHours >= 5)
            //            {
            //                finalPrice = priceWithDis * 0.50;
                           
            //            }
            //            Console.WriteLine($"Price per person for one hour: {price:f2}");
            //            Console.WriteLine($"Total cost of the visit: {finalPrice * countOfPeople:f2}");
            //        }
            //        break;
            //    case "june":
            //    case "july":
            //    case "august":
            //        if(partOfDay=="night")
            //        {
            //            price = 10.20;
            //            if(countOfPeople >= 4)
            //            {
            //                finalPrice = price * 0.10;
            //            }
            //            else
            //            {
            //                finalPrice = 10.20;
            //            }
            //            if(spentHours >= 5)
            //            {
            //                finalPrice = finalPrice * 0.50;
            //            }
            //            Console.WriteLine($"Price per person for one hour: {price:f2}");
            //            Console.WriteLine($"Total cost of the visit: {finalPrice * countOfPeople:f2}");
            //        }
                    
            //        break;

            }
            


        }
    }

