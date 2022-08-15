using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int free = 5;
            free -= i; // вадим от free и взимаме останалата му стойност
           
            Console.WriteLine(free);
        }
    }
}
