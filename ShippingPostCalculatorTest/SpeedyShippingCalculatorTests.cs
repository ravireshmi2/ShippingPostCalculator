using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ShippingPostCalculator;
using System.Linq;

namespace ShippingPostCalculatorTest
{
    [TestClass]
    class SpeedyShippingCalculatorTests
    {
        [TestMethod]
        public void WhenIPassInOneParcel_CostShouldBeDoubled()
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
        public void WhenIPassInListOfParcela_CostShouldBeDoubled()
        {
            //Arrange
            List<Parcel> parcelInput = new List<Parcel>();
            parcelInput.Add(new Parcel("A", 2, 5));
            parcelInput.Add(new Parcel("A", 10, 5));
            parcelInput.Add(new Parcel("A", 8, 5));


            //Act
            var result = parcelInput.CalculateDoubleParcelCost();
            var expectedOutput = parcelInput.Sum(x => x.Cost) * 2;

            //Assert
            Assert.AreEqual(expectedOutput, result);

        }
    }
}
