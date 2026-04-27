using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
    public class TopKFrequent
    {
        public class Solution
        {
            public int[] TopKFrequent(int[] nums, int k)
            {
                Dictionary<int, int> freq = new Dictionary<int, int>();

                foreach (int num in nums)
                {
                    if (!freq.ContainsKey(num))
                    {
                        freq[num] = 0;
                    }

                    freq[num]++;
                }

                var pq = new PriorityQueue<int, int>();

                foreach (var item in freq)
                {
                    int num = item.Key;
                    int count = item.Value;

                    pq.Enqueue(num, count);

                    if (pq.Count > k)
                    {
                        pq.Dequeue();
                    }
                }

                int[] result = new int[k];

                for (int i = 0; i < k; i++)
                {
                    result[i] = pq.Dequeue();
                }

                return result;
            }
        }
    }
}
