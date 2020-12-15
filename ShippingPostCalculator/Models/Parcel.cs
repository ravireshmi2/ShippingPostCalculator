using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPostCalculator.Models
{
    /// <summary>
    /// Class to withhold properties of a Parcel that we can use
    /// </summary>
    class Parcel
    {
        /// <summary>
        /// Represents the name of the parcel
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the maximum size a parcel can hold in all dimensions
        /// </summary>
        public int MaxSize { get; set; }

        /// <summary>
        /// Represents the cost
        /// </summary>
        public double Cost { get; set; }
    }
}
