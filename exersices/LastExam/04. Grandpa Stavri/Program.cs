using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= days; i++)
            {
                double quantityOfRakia = double.Parse(Console.ReadLine());
                double degreesPerLiter = double.Parse(Console.ReadLine());
                double SborNaDegreesForLiterRakia = quantityOfRakia * degreesPerLiter;


                //Second Day
                //totalQuantityForDay = quantityOfRakia + degreesPerLiter;
                //totalQuantityRakiaSince = SborNaDegreesForLiterRakia;
                totalLiter += quantityOfRakia;

                //Third Day
                //totalQuantityForDay = totalQuantityForDay+ quantityOfRakia;
                //SborNaDegreesForLiter =  totalQuantityRakiaSince +  (quantityOfRakia*degreesPerLiter)
                totalLiter += quantityOfRakia;

                //AvarageValue = SborNaDegreesForLiter/totalLiter;
            }
            Console.WriteLine($"Liter: {forTotalLast:f2}");
            Console.WriteLine("Degrees: {градусите на общата смес}");

        }
    }
}
