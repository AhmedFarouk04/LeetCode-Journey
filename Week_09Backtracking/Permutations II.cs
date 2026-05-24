using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Permutations_II
    {
        public class Solution
        {
            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                Array.Sort(nums);

                IList<IList<int>> result = new List<IList<int>>();
                List<int> current = new List<int>();
                bool[] used = new bool[nums.Length];

                void Backtrack()
                {
                    if (current.Count == nums.Length)
                    {
                        result.Add(new List<int>(current));
                        return;
                    }

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (used[i])
                            continue;

                        if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                            continue;

                        current.Add(nums[i]);
                        used[i] = true;

                        Backtrack();

                        current.RemoveAt(current.Count - 1);
                        used[i] = false;
                    }
                }

                Backtrack();

                return result;
            }
        }
    }
}
