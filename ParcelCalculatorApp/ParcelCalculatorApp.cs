using ShippingPostCalculator;
using System;

namespace ParcelCalculatorApp
{
    class ParcelCalculatorApp
    {
        static void Main(string[] args)
        {

            int sizeOfPkg;
            //int failedUserAttempts = 0;
            Console.WriteLine("Please enter size of package (cms) : ");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out sizeOfPkg))
            {
                ParcelCalculator calculator = new ParcelCalculator();
                Parcel parcelSize = calculator.CalculateCheapestParcelType(sizeOfPkg);
                Console.WriteLine($"Cheapest parcel size: {parcelSize.Name}");
                Console.WriteLine($"Cost of parcel: {parcelSize.Cost}");
            }
            else
            {

                Console.WriteLine("Invalid user input");
                //failedUserAttempts += 1; ;
                //if (failedUserAttempts <= MAX_FAILED_ATTEMPTS)
                //{
                //    var userInput = Console.ReadLine();
                //}
            }
        }
    }
}
