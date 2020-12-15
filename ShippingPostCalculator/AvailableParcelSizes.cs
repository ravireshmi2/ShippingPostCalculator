using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPostCalculator
{
    class AvailableParcelSizes
    {
        readonly Parcel SmallParcel = new Parcel("Small", 3, 0, 10);
        readonly Parcel MediumParcel = new Parcel("Medium", 8,11, 50);
        readonly Parcel LargeParcel = new Parcel("Large", 15, 51, 99);
        readonly Parcel XLParcel = new Parcel("XL", 25, 100);
    }
}
