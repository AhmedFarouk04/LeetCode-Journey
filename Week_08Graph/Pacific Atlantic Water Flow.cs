using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public class Pacific_Atlantic_Water_Flow
    {
        public class Solution
        {
            public IList<IList<int>> PacificAtlantic(int[][] heights)
            {
                int rows = heights.Length;
                int cols = heights[0].Length;

                bool[,] pacific = new bool[rows, cols];
                bool[,] atlantic = new bool[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    DFS(heights, r, 0, pacific);          // left edge = Pacific
                    DFS(heights, r, cols - 1, atlantic); // right edge = Atlantic
                }

                for (int c = 0; c < cols; c++)
                {
                    DFS(heights, 0, c, pacific);          // top edge = Pacific
                    DFS(heights, rows - 1, c, atlantic); // bottom edge = Atlantic
                }

                IList<IList<int>> result = new List<IList<int>>();

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (pacific[r, c] && atlantic[r, c])
                        {
                            result.Add(new List<int> { r, c });
                        }
                    }
                }

                return result;
            }

            private void DFS(int[][] heights, int r, int c, bool[,] visited)
            {
                visited[r, c] = true;

                int rows = heights.Length;
                int cols = heights[0].Length;

                int[][] directions =
                {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

                foreach (int[] dir in directions)
                {
                    int newR = r + dir[0];
                    int newC = c + dir[1];

                    if (newR < 0 || newR >= rows || newC < 0 || newC >= cols)
                        continue;

                    if (visited[newR, newC])
                        continue;

                    if (heights[newR][newC] < heights[r][c])
                        continue;

                    DFS(heights, newR, newC, visited);
                }
            }
        }
    }
}
