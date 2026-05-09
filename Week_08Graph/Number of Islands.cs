using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public class Number_of_Islands
    {
        public class Solution
        {
            public int NumIslands(char[][] grid)
            {
                int rows = grid.Length;
                int cols = grid[0].Length;
                int count = 0;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (grid[r][c] == '1')
                        {
                            count++;
                            DFS(grid, r, c);
                        }
                    }
                }

                return count;
            }

            private void DFS(char[][] grid, int r, int c)
            {
                int rows = grid.Length;
                int cols = grid[0].Length;

                if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
                    return;

                grid[r][c] = '0';

                DFS(grid, r + 1, c);
                DFS(grid, r - 1, c);
                DFS(grid, r, c + 1);
                DFS(grid, r, c - 1);
            }
        }
    }
}
