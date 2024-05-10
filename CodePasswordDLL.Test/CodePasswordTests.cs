using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using LR1;

namespace CodePasswordDLL.Test
{
    public class CodePasswordTests
    {
        [Fact]
        public void TestSumOfPositiveNumbers()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 8;
            double num4 = 9;

            double expected = 30; // 6 + 7 + 8 + 9 = 30
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfNegativeNumbers()
        {
            double num1 = -4;
            double num2 = -6;
            double num3 = -8;
            double num4 = -9;

            double expected = 0; // No numbers greater than 5
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfMixedNumbers()
        {
            double num1 = 6;
            double num2 = -6;
            double num3 = 8;
            double num4 = 4;

            double expected = 14; // 6 + 8 = 14
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfAllNumbersLessThanFive()
        {
            double num1 = 1;
            double num2 = 2;
            double num3 = 3;
            double num4 = 4;

            double expected = 0; // No numbers greater than 5
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfAllNumbersGreaterThanFive()
        {
            double num1 = 10;
            double num2 = 11;
            double num3 = 12;
            double num4 = 13;

            double expected = 46; // 10 + 11 + 12 + 13 = 46
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfAllNumbersEqualToFive()
        {
            double num1 = 5;
            double num2 = 5;
            double num3 = 5;
            double num4 = 5;

            double expected = 0; // No numbers greater than 5
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfOneNumberGreaterThanFive()
        {
            double num1 = 6;
            double num2 = 2;
            double num3 = 3;
            double num4 = 4;

            double expected = 6; // Only one number greater than 5
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfTwoNumbersGreaterThanFive()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 3;
            double num4 = 4;

            double expected = 13; // 6 + 7 = 13
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfThreeNumbersGreaterThanFive()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 8;
            double num4 = 4;

            double expected = 21; // 6 + 7 + 8 = 21
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSumOfFourNumbersGreaterThanFive()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 8;
            double num4 = 9;

            double expected = 30; // 6 + 7 + 8 + 9 = 30
            double actual = Class1.SumOfNumbersGreaterThanFive(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }
    }
}
