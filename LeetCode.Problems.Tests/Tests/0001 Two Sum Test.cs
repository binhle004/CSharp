using System.Collections.Generic;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace LeetCode.Problems.Tests.Problem1
{
    public class TwoSumTest
    {
        [Theory]
        [TestData]
        public void Brute_Force(int[] nums, int target, int[] expected)
        {
            var result = new TwoSum_BruteForce().TwoSum(nums, target);

            Assert.Equal(expected, result);
        }

        [Theory]
        [TestData]
        public void One_Pass(int[] nums, int target, int[] expected)
        {
            var result = new TwoSum_OnePass().TwoSum(nums, target);

            Assert.Equal(expected, result);
        }
    }

    public sealed class TestData : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } };
            yield return new object[] { new int[] { 2, 7, 11, 15 }, 26, new int[] { 2, 3 } };
            yield return new object[] { new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } };
        }
    }
}