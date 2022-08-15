using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int degrees = int.Parse(Console.ReadLine());
            string typeDay = Console.ReadLine();
            string outfit = " ";
            string shoes = " ";
            switch(typeDay)
            {
                case "Morning":
                    //10 <= градуси <= 18
                    //"It's {градуси} degrees, get your {облекло} and {обувки}."
                    if (degrees<=10 || degrees <= 18)
                    {
                        outfit = "Sweatshirt"; shoes = "Sneakers";
                        
                    }
                    else if (degrees < 18 || degrees <= 24)
                    {
                        //18 < градуси <= 24
                        outfit = "Shirt"; shoes = "Moccasins";
                        

                    }
                    else if (degrees >=25)
                    {
                        //18 < градуси <= 24
                        outfit = "T-Shirt"; shoes = "Sandals";
                        

                    }
                    break;
                case "Afternoon":
                    if (degrees <= 10 || degrees <= 18)
                    {
                        outfit = "Shirt"; shoes = "Moccasins";
                       
                    }
                    else if (degrees < 18 || degrees <= 24)
                    {
                        //18 < градуси <= 24
                        outfit = "T-Shirt"; shoes = "Sandals";
                        

                    }
                    else if (degrees >= 25)
                    {
                        //18 < градуси <= 24
                        outfit = "Swim Suit"; shoes = "Barefoot";
                        
                    }
                        break;
                case "Evening":
                    if (degrees <= 10 || degrees <= 18)
                    {
                        outfit = "Shirt"; shoes = "Moccasins";
                        
                    }
                    else if (degrees < 18 || degrees <= 24)
                    {
                        //18 < градуси <= 24
                        outfit = "Shirt"; shoes = "Moccasins";
                        

                    }
                    else if (degrees >= 25)
                    {
                        //18 < градуси <= 24
                        outfit = "Shirt"; shoes = "Moccasins";
                        
                        }
                    break;
                   
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");


        }
    }
}
