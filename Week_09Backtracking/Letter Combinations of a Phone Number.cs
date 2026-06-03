using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Letter_Combinations_of_a_Phone_Number
    {
        public class Solution
        {
            public IList<string> LetterCombinations(string digits)
            {
                IList<string> result = new List<string>();

                if (digits.Length == 0)
                    return result;

                string[] map = new string[]
                {
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
                };

                void Backtrack(int index, string current)
                {
                    if (index == digits.Length)
                    {
                        result.Add(current);
                        return;
                    }

                    int digit = digits[index] - '0';
                    string letters = map[digit];

                    foreach (char letter in letters)
                    {
                        Backtrack(index + 1, current + letter);
                    }
                }

                Backtrack(0, "");

                return result;
            }
        }
    }
}
