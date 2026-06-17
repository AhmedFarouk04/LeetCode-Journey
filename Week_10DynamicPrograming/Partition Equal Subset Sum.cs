using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_10DynamicPrograming
{
    public class Partition_Equal_Subset_Sum
    {
        public class Solution
        {
            public bool CanPartition(int[] nums)
            {
                int sum = 0;

                foreach (int num in nums)
                {
                    sum += num;
                }

                if (sum % 2 != 0)
                    return false;

                int target = sum / 2;

                bool[] dp = new bool[target + 1];

                dp[0] = true;

                foreach (int num in nums)
                {
                    for (int s = target; s >= num; s--)
                    {
                        dp[s] = dp[s] || dp[s - num];
                    }
                }

                return dp[target];
            }
        }
    }
}
