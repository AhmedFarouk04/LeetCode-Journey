using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_07Graph
{
    public  class Flood_Fill
    {
        public class Solution
        {
            public int[][] FloodFill(int[][] image, int sr, int sc, int color)
            {
                int oldColor = image[sr][sc];

                // Edge Case
                if (oldColor == color)
                    return image;

                DFS(image, sr, sc, oldColor, color);

                return image;
            }

            private void DFS(int[][] image, int r, int c, int oldColor, int newColor)
            {
                int rows = image.Length;
                int cols = image[0].Length;

                // Out of bounds
                if (r < 0 || r >= rows || c < 0 || c >= cols)
                    return;

                // Different color
                if (image[r][c] != oldColor)
                    return;

                // Color current cell
                image[r][c] = newColor;

                // Explore neighbors
                DFS(image, r + 1, c, oldColor, newColor); // down
                DFS(image, r - 1, c, oldColor, newColor); // up
                DFS(image, r, c + 1, oldColor, newColor); // right
                DFS(image, r, c - 1, oldColor, newColor); // left
            }
        }
    }
}
