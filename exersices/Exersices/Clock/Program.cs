using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0;
            while (i < 6)
            {
                i++;
                if (i % 2 == 0)
                    Console.Write(i);
            }

        }
    }
}
