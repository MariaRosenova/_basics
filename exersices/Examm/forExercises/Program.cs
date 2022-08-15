using System;
using System.Diagnostics.Tracing;

namespace forExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string grades = Console.ReadLine();

            while (grades!= " ")
            {
                int gradesNum = int.Parse(grades);
                if(gradesNum ==2)
                {
                    grades = Console.ReadLine();
                    break;
                }
                Console.WriteLine();
            }
        }
 
    }
}
