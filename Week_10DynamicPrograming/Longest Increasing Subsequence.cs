using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_10DynamicPrograming
{
    public class Longest_Increasing_Subsequence
    {
        public class Solution
        {
            public int LengthOfLIS(int[] nums)
            {
                int n = nums.Length;

                int[] dp = new int[n];

                Array.Fill(dp, 1);

                int answer = 1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[j] < nums[i])
                        {
                            dp[i] = Math.Max(dp[i], dp[j] + 1);
                        }
                    }

                    answer = Math.Max(answer, dp[i]);
                }

                return answer;
            }
        }
    }
}
