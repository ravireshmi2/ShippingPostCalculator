using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ShippingPostCalculator;
using System.Linq;

namespace ShippingPostCalculatorTest
{
    [TestClass]
    public class SpeedyShippingCalculatorTests
    {
        [TestMethod]
        public void WhenIPassInOneParcel_ExpectedSpeedyShippingCostShouldBeDoubled()
        {
            //Arrange
            List<Parcel> parcelInput = new List<Parcel>();
            parcelInput.Add(new Parcel("A", 2, 5));

            //Act
            var result = parcelInput.CalculateDoubleParcelCost();
            var expectedOutput = parcelInput[0].Cost * 2;

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }

        [TestMethod]
        public void WhenIPassInListOfParcela_ExpectedSpeedyShippingCostShouldBeDoubled()
        {
            //Arrange
            List<Parcel> parcelInput = new List<Parcel>();
            parcelInput.Add(new Parcel("A", 2, 5));
            parcelInput.Add(new Parcel("B", 10, 15));
            parcelInput.Add(new Parcel("C", 8, 25));


            //Act
            var result = parcelInput.CalculateDoubleParcelCost();
            var expectedOutput = parcelInput.Sum(x => x.Cost) * 2;

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }
        [TestMethod]
        public void WhenIPassInListOfParcelsWithCostAs0_ExpectedSpeedyShippingCostShouldBe0()
        {
            //Arrange
            List<Parcel> parcelInput = new List<Parcel>();
            parcelInput.Add(new Parcel("A", 0, 5));
            parcelInput.Add(new Parcel("B", 0, 15));



            //Act
            var result = parcelInput.CalculateDoubleParcelCost();
            var expectedOutput = parcelInput.Sum(x => x.Cost) * 2;

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }
    }
}
