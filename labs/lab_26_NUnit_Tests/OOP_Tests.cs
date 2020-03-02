using System;
using NUnit;
using NUnit.Framework;
using lab_27_test_addition;


namespace lab_26_NUnit_Tests
{
    class OOP_Tests
    {




        [TestCase(new int[] { 10, 11, 15, 25 }, -2)]
        public void Test_600_OOP_Array_While_Do_ForEach_Cat_List_Ages_Total_Test(int[] array, int expected) {
            var instance = new OOP_Code();
            var actual = instance.Test_600_OOP_Array_While_Do_ForEach_Cat_List_Ages_Total(array);
            Assert.AreEqual(expected, actual);

        }


        [TestCase(10, 10)]
        public void Test_WPF_Person_Generator_Test(int years, int expected)
        {
            var instance = new OOP_Code();
            var actual = instance.Random_Person_Generator(years);
            Assert.AreEqual(expected, actual);
        }

    }





}
