
using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using lab_37_northwind_core;

namespace lab_26_NUnit_Tests
{
    class Rabbit_Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        // tests go here 
        [Test]
        public void RabbitDummyTest()
        {
            Assert.AreEqual(91, 91);
        }

        [TestCase(1000, 20)]
        public void TestRabbitExplosion(int populationLimit, int expectedYears)
        {
            // arrange
            var instance = new Rabbit_Code();
            // act
            var actualYears = instance.Rabbit_Exponential_Growth(populationLimit);
            // assert
            Assert.AreEqual(expectedYears, actualYears);
        }

        #region TestRabbitGrowth
        [TestCase(3, 7, 8)]
        public void RabbitGrowthTests(int totalYears, int expectedRabbitAge, int expectedRabbitCount)
        {
            // Arrange
            var instance = new Rabbit_Code();
            // Act
            // Tuple (int NAME,int NAME)
            (int actualCumulativeAge, int actualRabbitCount) = 
                                           instance.MultiplyRabbits(totalYears);

            // Assert
            Assert.AreEqual(expectedRabbitAge, actualCumulativeAge);
            Assert.AreEqual(expectedRabbitCount, actualRabbitCount);
        }
        #endregion










        #region TestRabbitGrowthWhereItDoesNotBeginUntilThreeYearsAgeReached
        [TestCase(3, 3, 1)]
        [TestCase(4, 4, 2)]
        [TestCase(5, 6, 3)]
        [TestCase(6, 9, 4)]
        public void RabbitGrowthAfterThreeYears
            (int totalYears, int expectedRabbitAge,
                                   int expectedRabbitCount)
        {
            // Arrange
            var instance = new Rabbit_Code();
            // Act
            // Tuple (int NAME,int NAME)
            (int actualCumulativeAge, int actualRabbitCount) =
                     instance.MultiplyRabbitsAfterAgeThreeReached(totalYears);

            // Assert
            Assert.AreEqual(expectedRabbitAge, actualCumulativeAge);
            Assert.AreEqual(expectedRabbitCount, actualRabbitCount);
        }
        #endregion


        #region RabbitPopulationExplosionWhereDeathIsInvolved
        [TestCase(3, 5, 3, 1)]
        public void Test_Rabbit_Population_Where_Death_Involved_Test(int years, int maxAge, int expectedRabbitAge, 
            int expectedRabbitCount)
        {
            var instance = new Rabbit_Code();
            (int actualRabbitAge, int actualRabbitCount) = instance.RabbitPopulationWhereDeathInvolved(int years, int maxAge);
                
        }
        #endregion


    }
}


