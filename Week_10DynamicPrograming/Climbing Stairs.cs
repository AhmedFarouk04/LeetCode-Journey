using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_10DynamicPrograming
{
    public class Climbing_Stairs
    {
        public class Solution
        {
            public int ClimbStairs(int n)
            {
                int[] memo = new int[n + 1];

                return Ways(n, memo);
            }

            private int Ways(int n, int[] memo)
            {
                if (n == 1)
                    return 1;

                if (n == 2)
                    return 2;

                if (memo[n] != 0)
                    return memo[n];

                memo[n] = Ways(n - 1, memo) + Ways(n - 2, memo);

                return memo[n];
            }
        }
    }
}
