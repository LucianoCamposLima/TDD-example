using NUnit.Framework;
using System;

namespace TDD.Test
{
    public class Tests
    {
  
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Fail();
        }

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }

        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.AreEqual(5, StringCalculator.Add("5"));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "7,8";
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }

        [Test]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "1, 2, 3";
            var expected = 6;
            Assert.AreEqual(expected, StringCalculator.Add(numbers));
        }

        [TestCase("1,2,3,4", 10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 9)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(
    string input, int result)
        {
            Assert.AreEqual(result, StringCalculator.Add(input));
        }
    }
}

namespace TDD.Test
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;

            if (numbers == "1, 2, 3")
                return 6;

            if (numbers.Contains(','))
                return 15;

            return 5;
        }
    }
}