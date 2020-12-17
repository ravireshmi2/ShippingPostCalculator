using System.Collections.Generic;

namespace ShippingPostCalculator
{
    public class ParcelCalculator : BaseCalculator<Parcel>
    {
       
        public Parcel CalculateCheapestCost(int size)
        {
            if (size >= AvailableParcelSizes.SmallParcel.MinSize && size < AvailableParcelSizes.SmallParcel.MaxSize)
            {
                return AvailableParcelSizes.SmallParcel;
            }
            else if (size >= AvailableParcelSizes.SmallParcel.MinSize && size < AvailableParcelSizes.MediumParcel.MaxSize)
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

        public List<Parcel> CalculateCheapestCostForListOfInputs (List<int> sizesList)
        {
            List<Parcel> parcelsOutput = new List<Parcel>();
            for (int i = 0; i< sizesList.Count; i++){
                parcelsOutput.Add(CalculateCheapestCost(sizesList[i]));
            }
            return parcelsOutput;
        }

        

    }
}
