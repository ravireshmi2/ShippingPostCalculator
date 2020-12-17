using System.Collections.Generic;
using System.Linq;

namespace ShippingPostCalculator
{
    public static class SpeedyShippingOption
    {
        public static double CalculateDoubleParcelCost(this List<Parcel> currentShippingItem)
        {
            return currentShippingItem.Sum(x => x.Cost) * 2;
        }
    }
}
