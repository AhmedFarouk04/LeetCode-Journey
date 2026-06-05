using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_09Backtracking
{
    public class Word_Search
    {
        public class Solution
        {
            public bool Exist(char[][] board, string word)
            {
                int rows = board.Length;
                int cols = board[0].Length;

                bool Dfs(int r, int c, int index)
                {
                    if (index == word.Length)
                        return true;

                    if (r < 0 || r >= rows || c < 0 || c >= cols)
                        return false;

                    if (board[r][c] != word[index])
                        return false;

                    char temp = board[r][c];
                    board[r][c] = '#';

                    bool found =
                        Dfs(r + 1, c, index + 1) ||
                        Dfs(r - 1, c, index + 1) ||
                        Dfs(r, c + 1, index + 1) ||
                        Dfs(r, c - 1, index + 1);

                    board[r][c] = temp;

                    return found;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (Dfs(r, c, 0))
                            return true;
                    }
                }

                return false;
            }
        }
    }
}
