using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_07Heap
{
    public  class K_Closest_Points_to_Origin
    {
        public class Solution
        {
            public int[][] KClosest(int[][] points, int k)
            {
                var pq = new PriorityQueue<int[], int>();

                foreach (var point in points)
                {
                    int x = point[0];
                    int y = point[1];

                    int dist = x * x + y * y;

                    pq.Enqueue(point, -dist);

                    if (pq.Count > k)
                    {
                        pq.Dequeue();
                    }
                }

                int[][] result = new int[k][];

                for (int i = 0; i < k; i++)
                {
                    result[i] = pq.Dequeue();
                }

                return result;
            }
        }
    }
}
