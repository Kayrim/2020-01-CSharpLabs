//// using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace MS_Test
//{

//    [TestClass]
//    class MSTest_Tests
//    {

//        [TestMethod]
//        public void Check_RemoveMiddleWord()
//        {
//            var Tests = new SomeTests.SomeTest();
//            Assert.AreEqual("sup dude", Tests.RemoveMiddleWord("sup my dude"));
//            Assert.AreEqual("yeet yeet", Tests.RemoveMiddleWord("yeet yeet yeet"));
//        }

//        [TestMethod]
//        public void Check_SumOfArray()
//        {
//            var Tests = new SomeTests.SomeTest();
//            Assert.AreEqual(9, Tests.SumIgnoringMax(new int[] { 2, 3, 4, 5 }));
//            Assert.AreEqual(1005, Tests.SumIgnoringMax(new int[] { 999, 1000, 5, 1 }));
//            Assert.AreEqual(9, Tests.SumIgnoringMax(new int[] { 1, 2, 1, 1, 1, 1, 1, 1, 1, 1 }));
//        }

//        [TestMethod]
//        public void Check_Pyramid()
//        {
//            var Tests = new SomeTests.SomeTest();
//            CollectionAssert.AreEqual(new char[,] {
//            { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
//            { ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ' },
//            { ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
//            { ' ', '*', '*', '*', '*', '*', '*', '*', ' ' },
//            { '*', '*', '*', '*', '*', '*', '*', '*', '*' }
//        }, Tests.Pyramid(5, 9));
//            CollectionAssert.AreEqual(new char[,] {
//            { ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ' },
//            { ' ', ' ', ' ', ' ', ' ', '*', '*', '*', ' ', ' ', ' ', ' ', ' ' },
//            { ' ', ' ', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ', ' ', ' ' },
//            { ' ', ' ', ' ', '*', '*', '*', '*', '*', '*', '*', ' ', ' ', ' ' },
//            { ' ', ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', ' ', ' ' },
//            { ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', ' ' },
//            { '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*' }
//        }, Tests.Pyramid(7, 13));
//        }
//        [TestMethod]
//        public void Check_Different()
//        {
//            var Tests = new SomeTests.SomeTest();
//            CollectionAssert.AreEqual(new int[] { 1, 3, 4, 5 }, Tests.Different(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2 }));
//            CollectionAssert.AreEqual(new int[] { }, Tests.Different(new int[] { }, new int[] { 2, 3, 4 }));
//            CollectionAssert.AreEqual(new int[] { 2, 3, 4 }, Tests.Different(new int[] { 2, 3, 4 }, new int[] { }));
//        }

//        [TestMethod]
//        public void Check_AddYearToDate()
//        {
//            // arrange (setup)
//            var arrayInstance = new SomeTests.SomeTest();
//            var expectedOutput = "01/01/2020 00:00:00";
//            // act (run code)
//            var actualOutput = arrayInstance.AddAYear(2019, 1, 1);
//            // assert (see if test pass/fail)
//            Assert.AreEqual(expectedOutput, actualOutput);
//        }

//        [TestMethod]
//        public void Check_BubbleSort()
//        {
//            // arrange (setup)
//            var Instance = new SomeTests.SomeTest();
//            int[] expectedOutput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int[] unsorted = { 4, 2, 8, 3, 9, 10, 5, 6, 1, 7 };
//            // act (run code)
//            var actualOutput = Instance.BubSort(unsorted);
//            // assert (see if test pass/fail)
//            CollectionAssert.AreEqual(expectedOutput, actualOutput);
//        }

//        [TestMethod]
//        public void Check_ReverseString()
//        {
//            var arrayInstance = new SomeTests.SomeTest();
//            Assert.AreEqual("drow", arrayInstance.ReverseString("word"));
//            Assert.AreEqual("", arrayInstance.ReverseString(""));
//            Assert.AreEqual("arsenal", arrayInstance.ReverseString("lanesra"));
//            Assert.AreEqual("oop", arrayInstance.ReverseString("poo"));
//        }

//        [TestMethod]
//        public void Check_Quadratic()
//        {
//            // arrange (setup)
//            var Instance = new SomeTests.SomeTest();
//            int expectedOutput = -1;
//            // act (run code)
//            var actualOutput = Instance.Quadratic(3, 2, -1);
//            // assert (see if test pass/fail)
//            Assert.AreEqual(expectedOutput, actualOutput);
//        }

//        [TestMethod]
//        public void Check_FifthLetter()
//        {
//            // arrange (setup)
//            var unit = new SomeTests.SomeTest();
//            // assert (see if test pass/fail)
//            Assert.AreEqual('d', unit.FifthLetter("Named"));
//            Assert.AreEqual('k', unit.FifthLetter("Jdk a k"));
//            Assert.AreEqual('o', unit.FifthLetter("      hello"));
//            Assert.AreEqual(' ', unit.FifthLetter(" "));
//        }

//        [TestMethod]
//        public void Check_SumOfFours()
//        {
//            // arrange (setup)
//            var unit = new SomeTests.SomeTest();
//            // assert (see if test pass/fail)
//            Assert.AreEqual(12, unit.SumOfFours(10));
//            Assert.AreEqual(12, unit.SumOfFours(12));
//            Assert.AreEqual(148, unit.SumOfFours(42));
//        }

//        [TestMethod]
//        public void Check_NameReturn()
//        {
//            var unit = new SomeTests.SomeTest();
//            Assert.IsTrue(unit.NameReturn('j', 'e', 's', 's'));
//            Assert.IsTrue(unit.NameReturn('c', 'h', 'a', 'd'));
//            Assert.IsTrue(unit.NameReturn('a', 'd', 'a', 'm'));
//            Assert.IsFalse(unit.NameReturn('m', 'e', 's', 's'));
//            Assert.IsFalse(unit.NameReturn('b', 'e', 's', 't'));
//        }

//        [TestMethod]
//        public void Check_Smallest()
//        {
//            var arrayInstance = new SomeTests.SomeTest();
//            Assert.AreEqual(1, arrayInstance.Smallest(new[] { 9, 1, 4, 5, 2, 3, 6, 7, 8 }));
//            Assert.AreEqual(8, arrayInstance.Smallest(new[] { 90, 79, 55, 23, 22, 45, 60, 29, 8 }));
//        }

//        [TestMethod]
//        public void Check_NextSquare()
//        {
//            var arrayInstance = new SomeTests.SomeTest();
//            Assert.AreEqual(16, arrayInstance.NextSquare(9));
//            Assert.AreEqual(36, arrayInstance.NextSquare(25));
//        }

//        [TestMethod]
//        public void Check_GeometricSeries()
//        {
//            var arrayInstance = new SomeTests.SomeTest();
//            Assert.AreEqual(142.32, arrayInstance.GeometricSeries(10, 1.15, 20));
//            Assert.AreEqual(1.55, arrayInstance.GeometricSeries(1, 1.01, 45));
//        }

//        [TestMethod]
//        public void Check_RomanEncryption()
//        {
//            var instance = new SomeTests.SomeTest();
//            Assert.AreEqual("", instance.RomanEncryption(""));
//            Assert.AreEqual("Uryyb", instance.RomanEncryption("Hello"));
//            Assert.AreEqual("Guvf vf n frperg pbqr 1209654930", instance.RomanEncryption("This is a secret code 1209654930"));
//            Assert.AreEqual("V'ir eha bhg bs vqrnf", instance.RomanEncryption("I've run out of ideas"));
//        }

//        [TestMethod]
//        public void Check_RomanDecryption()
//        {
//            var instance = new SomeTests.SomeTest();
//            Assert.AreEqual("", instance.RomanDecryption(""));
//            Assert.AreEqual("Hello", instance.RomanEncryption("Uryyb"));
//            Assert.AreEqual("This is a secret code 1209654930", instance.RomanEncryption("Guvf vf n frperg pbqr 1209654930"));
//            Assert.AreEqual("I've run out of ideas", instance.RomanEncryption("V'ir eha bhg bs vqrnf"));
//        }

//        [TestMethod]
//        public void Check_Sum()
//        {
//            var instance = new SomeTest();
//            Assert.AreEqual(5, instance.Sum(3, -1));
//            Assert.AreEqual(3, instance.Sum(3, 3));
//            Assert.AreEqual(55, instance.Sum(0, 10));
//            Assert.AreEqual(-5, instance.Sum(-3, -2));
//            Assert.AreEqual(0, instance.Sum(-10, 10));
//        }




//    }


//}
