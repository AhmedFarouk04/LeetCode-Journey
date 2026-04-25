using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            var pq = new PriorityQueue<int, int>();

            foreach (int stone in stones)
            {
                pq.Enqueue(stone, -stone);
            }

            while (pq.Count > 1)
            {
                int first = pq.Dequeue();   // largest
                int second = pq.Dequeue();  // second largest

                if (first != second)
                {
                    int remaining = first - second;
                    pq.Enqueue(remaining, -remaining);
                }
            }

            return pq.Count == 0 ? 0 : pq.Dequeue();
        }
    }
}
