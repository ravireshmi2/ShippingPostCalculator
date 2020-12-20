using ShippingPostCalculator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcelCalculatorApp
{
    class ParcelCalculatorApp
    {
        static void Main(string[] args)
        {

            List<Parcel> totalParcelList = new List<Parcel>();
            Console.WriteLine("Please enter size of package (cms) separated by commas : ");
            var userInput = Console.ReadLine();
            Console.WriteLine("Would you like to opt in for speedy shipping? (y/n) : ");
            var speedyShippingInput = Console.ReadLine();
            string[] parcelSizes = userInput.Split(",");
            ParcelCalculator calculator = new ParcelCalculator();

            for (int i =0; i < parcelSizes.Length; i++)
            {
                if (int.TryParse(parcelSizes[i], out int sizeOfPkg))
                {
                    totalParcelList.Add(calculator.CalculateCheapestCost(sizeOfPkg));
                }
                else
                {
                    Console.WriteLine($"Invalid output: {parcelSizes[i]}. This is excluded from the total cost.");
                }
            }
            
            PrintOutput(totalParcelList);
            if(speedyShippingInput.ToLower().Equals("y"))
                PrintSpeedyShippingOutput(totalParcelList.CalculateDoubleParcelCost());
           
        }

        private static void PrintOutput(List<Parcel> totalParcels)
        {
            Console.WriteLine("{" + string.Join(", ", totalParcels.Select(parcel => $"{parcel.Name}={parcel.Cost}")) + "}");
            Console.WriteLine($"Total Cost: {totalParcels.Sum(parcel => parcel.Cost)}");
        }
        private static void PrintSpeedyShippingOutput(double totalCost)
        {
            Console.WriteLine($"Speedy Shipping Cost: {totalCost}");

        }
    }

}
