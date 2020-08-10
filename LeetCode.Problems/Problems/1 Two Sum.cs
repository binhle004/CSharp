using System.Collections.Generic;

/* 
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
*/

namespace LeetCode.Problems
{
    public class TwoSum_BruteForce
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[0];
        }
    }

    public class TwoSum_OnePass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    return new int[] { dict[target - nums[i]], i };
                    
                dict[nums[i]] = i;
            }
            
            return null;
        }
    }
}
