using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace LeetCode.Problems.Tests.Problem7
{
    public class ReverseIntegerTest
    {
        [Theory]
        [TestData]
        public void Division_Method(int input, int expected)
        {
            var result = new ReverseInteger_DivideBy10().Reverse(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [TestData]
        public void Fastest(int input, int expected)
        {
            var result = new ReverseInteger_Fastest().Reverse(input);

            Assert.Equal(expected, result);
        }
    }

    public sealed class TestData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { -2147483412, -2143847412 };
            yield return new object[] { 1534236469, 0 };
            yield return new object[] { -2147483648, 0 };
            yield return new object[] { 123, 321 };
            yield return new object[] { -123, -321 };
            yield return new object[] { 120, 21 };
        }
    }
}