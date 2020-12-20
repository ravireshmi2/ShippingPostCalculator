namespace ShippingPostCalculator
{
    /// <summary>
    /// Class to withhold properties of a Parcel that we can use
    /// </summary>
    public class Parcel
    {

        public Parcel(string name, double cost, int minSize)
        {
            Name = name;
            MinSize = minSize;
            Cost = cost;
        }
        public Parcel(string name, double cost, int minSize, int maxSize)
        {
            Name = name;
            MinSize = minSize;
            MaxSize = maxSize;
            Cost = cost;
        }

        /// <summary>
        /// Represents the name of the parcel
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the minimum size a parcel can hold in CMs
        /// </summary>
        public int MinSize { get; set; }

        /// <summary>
        /// Represents the maximum size a parcel can hold in CMs
        /// </summary>
        public int MaxSize { get; set; }

        /// <summary>
        /// Represents the cost
        /// </summary>
        public double Cost { get; set; }
    }
}
