using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace lab_26_NUnit_Tests
{
    class Medium_Tests
    {
        [SetUp]
        public void Setup()
        {

        }



        // Check when two numbers are multiplied together this generates an overflow exception
        // when the output exceeds the maximum value for a 32 bit integer

        [TestCase(2000000000,2000000000)]
        public void Throw_Exception_Test(int x, int y)
        {
            var instance = new Medium_Code();
            var actual = instance.Test_560_Throw_Exception_Test(x,y);
            Assert.AreEqual(1, 0);

        }
    }
}
