using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Palindrome_Partitioning
    {
        public class Solution
        {
            public IList<IList<string>> Partition(string s)
            {
                IList<IList<string>> result = new List<IList<string>>();
                List<string> current = new List<string>();

                void Backtrack(int start)
                {
                    if (start == s.Length)
                    {
                        result.Add(new List<string>(current));
                        return;
                    }

                    for (int end = start; end < s.Length; end++)
                    {
                        if (!IsPalindrome(s, start, end))
                            continue;

                        string part = s.Substring(start, end - start + 1);

                        current.Add(part);

                        Backtrack(end + 1);

                        current.RemoveAt(current.Count - 1);
                    }
                }

                bool IsPalindrome(string text, int left, int right)
                {
                    while (left < right)
                    {
                        if (text[left] != text[right])
                            return false;

                        left++;
                        right--;
                    }

                    return true;
                }

                Backtrack(0);

                return result;
            }
        }
    }
}
