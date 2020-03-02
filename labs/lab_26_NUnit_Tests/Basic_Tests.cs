using System;
using NUnit;
using NUnit.Framework;
using lab_27_test_addition;


namespace lab_26_NUnit_Tests
{
    class Basic_Tests
    {
        // CREATE UNIFORM TESTING ENVIRONMENT - PERHAPS LOAD STARTUP INFO FROM DATABASE
        [SetUp]
        public void Setup()
        {

        }


        [TestCase(1, 2, 3)]
        [TestCase(3, 6, 9)]
        [TestCase(5, 7, 12)]
        [TestCase(2, 2, 4)]
        [TestCase(1000, 2000, 3000)]
        public void TestAdditionDemo(int a, int b, int expected)
        {
            // Arrange - set up test ready to run.  
            //         - create instances of test classes
            var instance = new Addition();

            // Act - run code to get 'actual' value
            var actual = instance.AddTwoNumbers(a, b);

            // Assert - assert.AreEqual(actual,expected);
            Assert.AreEqual(expected, actual);
        }




        /* Sum Even Numbers To a given value */
        [TestCase(100,-1)]
        public void Sum_Even_Numbers_Return_Total_Test(int maxValue, int expected)
        {
            var instance = new Basic_Code();
            var actual = instance.Sum_Even_Numbers_Return_Total(maxValue);
            Assert.AreEqual(expected, actual);
        }


        // pass in an integer array and return the sum
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        public void LINQ_Aggregate(int[] array, int expected)
        {
            // pass in array and get back sum : check is valid
            // arrange
            var instance = new Basic_Code();
            // act
            var actual = instance.Return_Sum_Of_Array(array);
            // assert
            Assert.AreEqual(expected, actual);
        }





        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 9)]

        public void Sum2DArrayTest(int numrows, int numcolumns, int expected)
        {
            // arrange

            // act

            // assert
        }

        [TestCase(3, 3, 3, 27)]
        [TestCase(4, 4, 4, 96)]
        public void Sum3DCubeTest(int x, int y, int z, int expected)
        {
            // arrange
            var instance = new Basic_Code();
            // act
            var actual = instance.Test_120_Sum_3D_Cube(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, 3, 27)]
        [TestCase(4, 4, 4, 96)]
        public void Sum3DCubeTest2(int x, int y, int z, int expected)
        {
            // arrange
            var instance = new Basic_Code();
            // act
            var actual = instance.Test_120_Sum_3D_Cube_With_ForEach(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1, 1, 0)]
        [TestCase(2, 2, 2, 1)]
        [TestCase(3, 3, 3, 27)]
        [TestCase(4, 4, 4, 216)]
        public void Sum3DCubeTest03(int x, int y, int z, int expected)
        {
            var instance = new Basic_Code();
            var actual = instance.ReturnSumOf3DArray(x, y, z);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, 52)]
        [TestCase(new int[] { 1, 1 }, 20)]
        public void Test_126_Loops(int[] array, int expected)
        {
            // Arrange
            var instance = new Basic_Code();

            // Act
            var actual = instance.Test_126_Loops(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }



        // Return total of ASCII characters in a string
        [TestCase("Hello World", -2)]
        public void Test_170_Sum_Of_ASCII_Values_Of_A_String_Test
            (string testString, int expected)
        {
            var instance = new Basic_Code();
            var actual = instance.Test_170_Sum_ASCII_Values_Of_String(testString);
            Assert.AreEqual(expected, actual);
        }


        // Return total of ASCII characters in a string minus spaces
        [TestCase("Hello World", -2)]
        public void Test_180_Sum_Of_ASCII_Values_Of_A_String_Test
            (string testString, int expected)
        {
            var instance = new Basic_Code();
            var actual = instance.Test_180_Sum_ASCII_Values_Of_String(testString);
            Assert.AreEqual(expected, actual);
        }



        public void Test_Spongebob()
        {
            var instance = new Basic_Code();
            Assert.AreEqual("hElLo", instance.TextToSpongeBobMeme("Hello"));
            Assert.AreEqual("jQuErY iS bEtTeR", instance.TextToSpongeBobMeme("jQuery is better"));
            Assert.AreEqual("", instance.TextToSpongeBobMeme(""));
        }


        #region ArrayListDictionaryGetTotal
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 280)]
        [TestCase(new int[] { 1, 4, 9, 16, 25 }, 1604)]
        [TestCase(new int[] { 10, 11, 12, 13, 14 }, 1405)]
        public void ArrayListDictionaryGetTotal(int[] array, int expected)
        {
            // call method in OTHER PROJECT 
            var instance = new Basic_Code();
            int actual = instance.Test_270_Array_List_Dictionary_Get_Total(array);
            // get answer
            // see if answer is correct or not 
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }





}
