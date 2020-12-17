using System.Collections.Generic;

namespace ShippingPostCalculator
{
    interface SpeedyShippingCalculator<T>
    {
        double CalculateSpeedyShippingCost(List<T> currentShippingItem);
    }
}
