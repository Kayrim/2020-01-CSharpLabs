using System;
using NUnit;
using NUnit.Framework;
using lab_28_test_practice;



namespace lab_26_Nunit_Tests
{

    class NunitTests
    {
        //Create uniform testing environment 
        [SetUp]

        public void Setup()
        {

        }
        [TestCase(1, 2, 3)]
        public void TestAdditionDemo(int a, int b, int expected)
        {
            // Arrange - set up test ready to run, create instances of the test class
           // var instance = new Addition();
            // Act - Run the code - to get a value
           // var actual = instance.addTwoNumbers(a, b);
            // Assert - assert.AreEqual(actual, expected);
           // Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 2, 2)]
        public void Test2DArraySum(int rows, int cols, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_100_Sum_2D_Array(rows, cols);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 2, 2, 1)]
        [TestCase(2, 1, 3, 0)]
        [TestCase(0, 0, 0, 0)]

        public void Test3DArraySum(int one, int two, int three, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_120_Sum_3D_Cube(one, two, three);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 1)]
        [TestCase(3, 5)]
        [TestCase(4, 14)]
        public void Test_125_Build_Array_And_Return_Sum_Of_Squares5(int arraySize, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_125_Build_Array_And_Return_Sum_Of_Squares(arraySize);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2 ,3, 4}, 52)]
       // [TestCase(3, 5)]
       // [TestCase(4, 14)]
        public void Test_126_Loops(int[] array, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_126_Loops(array);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(2,4,2,4)]
        [TestCase(2,9,3,5)]
        [TestCase(4,6,3,6)]
        
        public void Test_130_BIDMAS(int a, int b , int c, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_130_BIDMAS(a,b,c);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,2,2,2,1,1,2, 4)]
        public void Test_140_BIDMAS(int a, int b, int c, int d, int e, int f, int n, double expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_140_BIDMAS(a,b,c,d,e,f,n);

            Assert.AreEqual(expected, actual);
        }
        [TestCase('1', 1)]
        public void Test_150_Return_Integer_Of_Char(char c, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_150_Return_Integer_Of_Char(c);

            Assert.AreEqual(expected, actual);
        }
        [TestCase("hello", 3, 108)]
        public void Test_160_ASCII_Return_Index_Of_String(string input, int index, int expected)
        {
            var instance = new Basic_Tests();

            var actual = instance.Test_160_ASCII_Return_Index_Of_String(input, index);

            Assert.AreEqual(expected, actual);
        }
    }
    
}
