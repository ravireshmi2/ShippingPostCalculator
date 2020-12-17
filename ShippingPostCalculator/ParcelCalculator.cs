using System.Collections.Generic;

namespace ShippingPostCalculator
{
    public class ParcelCalculator : BaseCalculator<Parcel>, SpeedyShippingCalculator<Parcel>
    {
       
        public Parcel CalculateCheapestCost(int size)
        {
            if (size >= AvailableParcelSizes.SmallParcel.MinSize && size < AvailableParcelSizes.SmallParcel.MaxSize)
            {
                return AvailableParcelSizes.SmallParcel;
            }
            else if (size >= AvailableParcelSizes.MediumParcel.MinSize && size < AvailableParcelSizes.MediumParcel.MaxSize)
            {
                return AvailableParcelSizes.MediumParcel;
            }
            else if (size >= AvailableParcelSizes.MediumParcel.MaxSize && size < AvailableParcelSizes.LargeParcel.MinSize)
            {
                return AvailableParcelSizes.LargeParcel;
            }
            else 
            {
                return AvailableParcelSizes.XLParcel;
            }
        }

        public double CalculateSpeedyShippingCost(List<Parcel> currentShippingItem)
        {
            double totalCost = 0;
            for(int i = 0; i < currentShippingItem.Count; i++)
            {
                totalCost += currentShippingItem[i].Cost * 2;
            }
            return totalCost;
        }

    }
}
