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
            string[] parcelSizes = userInput.Split(",");
            ParcelCalculator calculator = new ParcelCalculator();

            for (int i =0; i < parcelSizes.Length; i++)
            {
                if (int.TryParse(parcelSizes[i], out int sizeOfPkg))
                {
                    totalParcelList.Add(calculator.CalculateCheapestParcelType(sizeOfPkg));
                }
                else
                {
                    Console.WriteLine($"Invalid output: {parcelSizes[i]}. This is excluded from the total cost.");
                }
            }
            
            PrintOutput(totalParcelList);

           
        }

        private static void PrintOutput(List<Parcel> totalParcels)
        {
            Console.WriteLine("{" + string.Join(", ", totalParcels.Select(parcel => $"{parcel.Name}={parcel.Cost}")) + "}");
            Console.WriteLine($"Total Cost: {totalParcels.Sum(parcel => parcel.Cost)}");
        }
    }
}
