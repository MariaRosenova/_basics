using System;
using System.Threading.Channels;

namespace _07WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            //като работното време на офисът е от 10-18 часа, от понеделник до събота включително
            double hour = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            switch (dayOfWeek)
            {  
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hour >= 10 && hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else if (!(hour >= 10 && hour <= 18) )

                    { Console.WriteLine("closed"); }

                    else if (dayOfWeek == "Sunday")

                    { Console.WriteLine("closed"); }
                    break;

                    default:
                    Console.WriteLine("closed"); 
               
                    break;
                    
                 
                    
                   
                       
                    
            }
        }
    }
}
