using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CabInvoiceGenertorTestProject
{
    public class Tests
    {
        InvoiceGenerator invoice = new InvoiceGenerator();

        [Test]
        [TestCase(5, 5, 55, RideType.NORMAL)]
        [TestCase(5, 5, 85, RideType.PREMIUM)]
        [TestCase(0.2, 1, 5, RideType.NORMAL)]
        public void Given_Distance_And_Time_Return_TotalFare(double distance, int time, double expected, RideType rideType)
        {
            //Arrange
            invoice = new InvoiceGenerator();

            Ride ride = new Ride(distance, time, rideType);
            //Act
            double actual = invoice.CalculateFare(ride);

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [Test]
        public void Given_Multiple_Rides_Return_TotalFare()
        {
            //Arrage

            Ride[] rides = { new Ride(5, 2, RideType.NORMAL), new Ride(2, 3, RideType.PREMIUM) };
            InvoiceSummary expected = new InvoiceSummary(44, rides.Length);
            //Act
            //double actual= invoice.CalculateFare(rides);
            InvoiceSummary actual = invoice.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, actual);
            //expected.Equals(actual);  
        }
    }
}
