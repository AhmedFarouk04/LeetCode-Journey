using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_10DynamicPrograming
{
    public class House_Robber
    {
        public class Solution
        {
            public int Rob(int[] nums)
            {
                int robTwoBefore = 0;
                int robOneBefore = 0;

                foreach (int money in nums)
                {
                    int take = money + robTwoBefore;
                    int skip = robOneBefore;

                    int current = Math.Max(take, skip);

                    robTwoBefore = robOneBefore;
                    robOneBefore = current;
                }

                return robOneBefore;
            }
        }
    }
}
