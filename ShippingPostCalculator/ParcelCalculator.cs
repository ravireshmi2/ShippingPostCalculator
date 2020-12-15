namespace ShippingPostCalculator
{
    public class ParcelCalculator : BaseCalculator
    {

        public Parcel CalculateCheapestParcelType(int size)
        {
            if (size > AvailableParcelSizes.SmallParcel.MinSize && size < AvailableParcelSizes.SmallParcel.MaxSize)
            {
                return AvailableParcelSizes.SmallParcel;
            }
            else if (size > AvailableParcelSizes.MediumParcel.MinSize && size < AvailableParcelSizes.MediumParcel.MaxSize)
            {
                return AvailableParcelSizes.MediumParcel;
            }
            else 
            {
                return AvailableParcelSizes.XLParcel;
            }
        }
    }
}
