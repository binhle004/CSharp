using System;
using System.Collections.Generic;

/* 
    Given a 32-bit signed integer, reverse digits of an integer.

    Example 1:

    Input: 123
    Output: 321
    Example 2:

    Input: -123
    Output: -321
    Example 3:

    Input: 120
    Output: 21
    Note:
    Assume we are dealing with an environment which could only store integers within the 32-bit 
    signed integer range: [−231,  231 − 1]. For the purpose of this problem, 
    assume that your function returns 0 when the reversed integer overflows.
*/

namespace LeetCode.Problems
{
    public class ReverseInteger_DivideBy10
    {
        public int Reverse(int x)
        {
            if (x <= Int32.MinValue || x >= Int32.MaxValue) return 0;

            int reversed = 0;
            bool isNegative = false;

            if (x < 0)
            {
                x = Math.Abs(x);
                isNegative = true;
            }

            while (x > 0)
            {
                if (reversed > int.MaxValue / 10) // guard for case when reversed will cause overflow after adding last digit
                    return 0;
                
                reversed = reversed * 10 + (x % 10);

                x /= 10;
            }

            return isNegative ? 0 - reversed : reversed;
        }
    }

    public class ReverseInteger_Fastest
    {
        public int Reverse(int x)
        {
            int reversed = 0;
            for (int pop, push; x != 0; x /= 10)
            {
                unchecked
                {
                    pop = x % 10;
                    push = reversed * 10 + pop;
                    if ((push - pop) / 10 != reversed) // guard to check that adding last digit hasn't overflowed
                        return 0;
                    reversed = push;
                }
            }
            return reversed;
        }
    }
}
