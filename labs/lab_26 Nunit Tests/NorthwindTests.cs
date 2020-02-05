using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using lab_36_Northwind_core;

namespace lab_26_Nunit_Tests
{
    class NorthwindTests
    {
        [SetUp]

        public void Setup()
        {

        }

        //Tests below
        [Test]
        public void TestCustomerList()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestCustomerList1();

            Assert.AreEqual(91,actual);
        }
        [Test]
        public void TestCustomerListAgain()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestCustomerList2();

            Assert.AreEqual(92, actual);
        }
        [Test]
        public void TestCustomerListOneMore()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestCustomerList3();

            Assert.AreEqual(91, actual);
        }
        [Test]
        public void TestProductCount()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestProducts();

            Assert.AreEqual(77, actual);
        }  
        [Test]
        public void TestProductStartingWithP()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestProductsWithGivenLetter();

            Assert.AreEqual(3, actual);
        }
        [Test]
        public void TestProductsContainingA()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestProductsContainingGivenLetter();

            Assert.AreEqual(58, actual);
        }
        [Test]
        public void TestCustomersWithinCityLondon()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestCustomersWithinGivenCity();

            Assert.AreEqual(6, actual);
        }
        [Test]
        public void TestCustomersWithinCountryOver3()
        {
            var instance = new TestsforNorth();

            var actual = instance.TestCustomersWithGivenCountry();

            Assert.AreEqual(8, actual);
        }
    }
}
