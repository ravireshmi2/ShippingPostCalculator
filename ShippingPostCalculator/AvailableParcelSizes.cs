using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPostCalculator
{
    public static class AvailableParcelSizes
    {
        public static Parcel SmallParcel = new Parcel("Small", 3, 0, 10);
        public static Parcel MediumParcel = new Parcel("Medium", 8, 11, 50);
        public static Parcel LargeParcel = new Parcel("Large", 15, 51, 99);
        public static Parcel XLParcel = new Parcel("XL", 25, 100);
    }
}
