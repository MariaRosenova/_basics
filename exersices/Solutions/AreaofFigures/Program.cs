using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            //double cm = double.Parse(Console.ReadLine());
            //double lenght = double.Parse(Console.ReadLine());
            if (figureType == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double s = 0;
                s = lenght * lenght;
                Console.WriteLine(s);
            }
            else if (figureType == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double lenght2 = double.Parse(Console.ReadLine());
                double s = 0;
                s = lenght * lenght2;
                Console.WriteLine(s);
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = 0;
                //S=π⋅r 
                s = Math.PI * Math.Pow(r, 2);
                Console.WriteLine(s);
            }
            else if(figureType== "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double s = 0;
                //S = ½(a.ha)
                s = 0.5*(lenght * height);
                Console.WriteLine(s);
            }

        }
    }
}
