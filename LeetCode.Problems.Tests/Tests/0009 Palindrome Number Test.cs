using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace LeetCode.Problems.Tests.Problem9
{
    public class PalindromeNumberTest
    {
        [Theory]
        [TestData]
        public void Compare_Array(int input, bool expected)
        {
            var result = new PalindromeNumber_CompareArray().IsPalindrome(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [TestData]
        public void Compare_Whole_Reverse(int input, bool expected)
        {
            var result = new PalindromeNumber_CompareReverse().IsPalindrome(input);

            Assert.Equal(expected, result);
        }


        [Theory]
        [TestData]
        public void Compare_Reverted(int input, bool expected)
        {
            var result = new PalindromeNumber_Fastest().IsPalindrome(input);

            Assert.Equal(expected, result);
        }
    }

    public sealed class TestData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 121, true };
            yield return new object[] { -121, false };
            yield return new object[] { 1221, true };
            yield return new object[] { 10, false };
        }
    }
}