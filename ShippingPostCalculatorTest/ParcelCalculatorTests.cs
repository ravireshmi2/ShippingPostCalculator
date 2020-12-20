using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingPostCalculator;

namespace ShippingPostCalculatorTest
{
    [TestClass]
    public class ParcelCalculatorTests
    {
        [TestMethod]
        public void WhenSizeIsAnInteger_ExpectSmallParcelSizeToBeReturned()
        {
            //Arrange
            ParcelCalculator calc = new ParcelCalculator();
            int input = 0;

            //Act
            var result = calc.CalculateCheapestCost(input);

            //Assert
            Assert.IsTrue(result is Parcel);
            Assert.IsTrue(result.Name.Equals(AvailableParcelSizes.SmallParcel.Name));
            Assert.IsTrue(result.Cost.Equals(AvailableParcelSizes.SmallParcel.Cost));

        }
        [TestMethod]
        public void WhenSizeIsInMinBoundarySizeLike50_ExpectLargeParcelToBeReturned()
        {
            //Arrange
            ParcelCalculator calc = new ParcelCalculator();
            int input = 50;

            //Act
            var result = calc.CalculateCheapestCost(input);

            //Assert
            Assert.IsTrue(result is Parcel);
            Assert.IsTrue(result.Name.Equals(AvailableParcelSizes.LargeParcel.Name));
            Assert.IsTrue(result.Cost.Equals(AvailableParcelSizes.LargeParcel.Cost));

        }
        [TestMethod]
        public void WhenSizeIsInMaxBoundarySizeLike49_ExpectMediumParcelToBeReturned()
        {
            //Arrange
            ParcelCalculator calc = new ParcelCalculator();
            int input = 49;

            //Act
            var result = calc.CalculateCheapestCost(input);

            //Assert
            Assert.IsTrue(result is Parcel);
            Assert.IsTrue(result.Name.Equals(AvailableParcelSizes.MediumParcel.Name));
            Assert.IsTrue(result.Cost.Equals(AvailableParcelSizes.MediumParcel.Cost));

        }
    }
}
