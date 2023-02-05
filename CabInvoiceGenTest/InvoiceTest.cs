using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenTest
{
    [TestClass]
    public class InvoiceTest
    {
        [DataRow(15, 10, 160)]
        [DataRow(30, 3, 303)]
        [TestMethod]
        public void GivenProperTimeAndDistanceShouldPass(double distance, int time, double expected)
        {
            CabInvoiceGen ride = new CabInvoiceGen();
            double actual = ride.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
