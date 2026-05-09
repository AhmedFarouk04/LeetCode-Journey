using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public class Rotting_Oranges
    {
        public class Solution
        {
            public int OrangesRotting(int[][] grid)
            {
                int rows = grid.Length;
                int cols = grid[0].Length;

                Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

                int fresh = 0;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (grid[r][c] == 2)
                        {
                            queue.Enqueue((r, c));
                        }
                        else if (grid[r][c] == 1)
                        {
                            fresh++;
                        }
                    }
                }

                if (fresh == 0)
                    return 0;

                int minutes = 0;

                int[][] directions =
                {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

                while (queue.Count > 0 && fresh > 0)
                {
                    int levelSize = queue.Count;

                    for (int i = 0; i < levelSize; i++)
                    {
                        var current = queue.Dequeue();

                        int r = current.r;
                        int c = current.c;

                        foreach (var dir in directions)
                        {
                            int newR = r + dir[0];
                            int newC = c + dir[1];

                            if (newR < 0 || newR >= rows || newC < 0 || newC >= cols)
                                continue;

                            if (grid[newR][newC] != 1)
                                continue;

                            grid[newR][newC] = 2;
                            fresh--;

                            queue.Enqueue((newR, newC));
                        }
                    }

                    minutes++;
                }

                if (fresh > 0)
                    return -1;

                return minutes;
            }
        }
    }
}
