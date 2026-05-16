using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Subsets
    {
        public class Solution
        {
            public IList<IList<int>> Subsets(int[] nums)
            {
                IList<IList<int>> result = new List<IList<int>>();

                void Backtrack(int start, List<int> current)
                {
                    result.Add(new List<int>(current));

                    for (int i = start; i < nums.Length; i++)
                    {
                        // choose
                        current.Add(nums[i]);

                        // explore
                        Backtrack(i + 1, current);

                        // unchoose
                        current.RemoveAt(current.Count - 1);
                    }
                }

                Backtrack(0, new List<int>());

                return result;
            }
        }
    }
}
