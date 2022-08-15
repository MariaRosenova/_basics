using System;

namespace _09FruitorVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // fruits - banana, apple, kiwi, cherry, lemon и grapes
            //vegetable - tomato, cucumber, pepper и carrot
            // other - unknown
            string fruitOrVegetable = Console.ReadLine();
            switch (fruitOrVegetable)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
