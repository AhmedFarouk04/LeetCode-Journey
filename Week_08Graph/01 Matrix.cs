using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public  class _01_Matrix
    {
        public class Solution
        {
            public int[][] UpdateMatrix(int[][] mat)
            {
                int rows = mat.Length;
                int cols = mat[0].Length;

                int[][] result = new int[rows][];

                Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

                for (int r = 0; r < rows; r++)
                {
                    result[r] = new int[cols];

                    for (int c = 0; c < cols; c++)
                    {
                        if (mat[r][c] == 0)
                        {
                            result[r][c] = 0;
                            queue.Enqueue((r, c));
                        }
                        else
                        {
                            result[r][c] = -1;
                        }
                    }
                }

                int[][] directions =
                {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();

                    int r = current.r;
                    int c = current.c;

                    foreach (int[] dir in directions)
                    {
                        int newR = r + dir[0];
                        int newC = c + dir[1];

                        if (newR < 0 || newR >= rows || newC < 0 || newC >= cols)
                            continue;

                        if (result[newR][newC] != -1)
                            continue;

                        result[newR][newC] = result[r][c] + 1;

                        queue.Enqueue((newR, newC));
                    }
                }

                return result;
            }
        }
    }
}
