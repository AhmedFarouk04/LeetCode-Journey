using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
    public class Kth_Largest_Element_in_an_Array
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                pq.Enqueue(num, num);

                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            return pq.Peek();
        }
    }
}
