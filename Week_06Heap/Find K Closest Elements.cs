using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
    public  class Find_K_Closest_Elements
    {
        public class Solution
        {
            public IList<int> FindClosestElements(int[] arr, int k, int x)
            {
                var pq = new PriorityQueue<int, (int distance, int value)>(
                    Comparer<(int distance, int value)>.Create((a, b) =>
                    {
                        if (a.distance != b.distance)
                            return b.distance.CompareTo(a.distance);

                        return b.value.CompareTo(a.value);
                    })
                );

                foreach (int num in arr)
                {
                    int distance = Math.Abs(num - x);

                    pq.Enqueue(num, (distance, num));

                    if (pq.Count > k)
                    {
                        pq.Dequeue();
                    }
                }

                var result = new List<int>();

                while (pq.Count > 0)
                {
                    result.Add(pq.Dequeue());
                }

                result.Sort();

                return result;
            }
        }
    }
}
