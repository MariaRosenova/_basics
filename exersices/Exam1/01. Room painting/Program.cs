using System;
using System.Xml.Schema;

namespace _01._Room_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
         
            int countOfPaints = int.Parse(Console.ReadLine());
            int countOfWallpapers = int.Parse(Console.ReadLine());
            double countOfGloves = double.Parse(Console.ReadLine());
            double countOfBrushes = double.Parse(Console.ReadLine());

           
            double priceForPaints = (countOfPaints * 1.0) * 21.50;
            
            double priceForWallpapers = (countOfWallpapers * 1.0) * 5.20;
            
            double priceForGloves = Math.Ceiling((countOfWallpapers * 0.35));
            
            double priceForBrushes = Math.Floor((countOfPaints * 1.0) * 0.48);
           
            double total = (priceForPaints + priceForWallpapers + (priceForGloves* countOfGloves) + (priceForBrushes* countOfBrushes)) /15;

            Console.WriteLine($"This delivery will cost {total:f2} lv.");

            }
        }
    }

