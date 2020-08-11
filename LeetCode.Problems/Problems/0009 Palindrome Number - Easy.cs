using System.Collections.Generic;
using System.Linq;

/* 
    Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
    
    Example 1:

    Input: 121
    Output: true
    Example 2:

    Input: -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
*/

namespace LeetCode.Problems
{
    /// <summary>
    /// Break up number into array and compare the corresponding left and right digits
    /// </summary>
    public class PalindromeNumber_CompareArray
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var list = new List<int>();

            for (; x != 0; x /= 10)
                list.Add(x % 10);

            for (int leftDigit = 0; leftDigit < (list.Count + 1) / 2; leftDigit++)
            {
                int rightDigit = list.Count - leftDigit - 1;

                if (list[leftDigit] != list[rightDigit])
                    return false;
            }

            return true;
        }
    }

    /// <summary>
    /// Compare the original number with it's reverse
    /// </summary>
    public class PalindromeNumber_CompareReverse
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var original = x;
            var reversed = 0;

            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            return reversed == original;
        }
    }

    /// <summary>
    /// Compare the reverted number to corresponding original
    /// </summary>
    public class PalindromeNumber_Fastest
    {
        public bool IsPalindrome(int x)
        {
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int revertedNumber = 0;

            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
