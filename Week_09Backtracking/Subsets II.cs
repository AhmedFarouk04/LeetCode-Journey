using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Subsets_II
    {
        public class Solution
        {
            public IList<IList<int>> SubsetsWithDup(int[] nums)
            {
                Array.Sort(nums);

                IList<IList<int>> result = new List<IList<int>>();

                void Backtrack(int start, List<int> current)
                {
                    result.Add(new List<int>(current));

                    for (int i = start; i < nums.Length; i++)
                    {
                        if (i > start && nums[i] == nums[i - 1])
                            continue;

                        current.Add(nums[i]);

                        Backtrack(i + 1, current);

                        current.RemoveAt(current.Count - 1);
                    }
                }

                Backtrack(0, new List<int>());

                return result;
            }
        }
    }
}
