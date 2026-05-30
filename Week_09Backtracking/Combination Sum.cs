using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
      public class Combination_Sum
    {
        public class Solution
        {
            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                IList<IList<int>> result = new List<IList<int>>();
                List<int> current = new List<int>();

                void Backtrack(int start, int remaining)
                {
                    if (remaining == 0)
                    {
                        result.Add(new List<int>(current));
                        return;
                    }

                    if (remaining < 0)
                    {
                        return;
                    }

                    for (int i = start; i < candidates.Length; i++)
                    {
                        current.Add(candidates[i]);

                        Backtrack(i, remaining - candidates[i]);

                        current.RemoveAt(current.Count - 1);
                    }
                }

                Backtrack(0, target);

                return result;
            }
        }
    }
}
