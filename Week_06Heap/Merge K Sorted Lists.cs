using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
    public  class Merge_K_Sorted_Lists
    {
        public class Solution
        {
            public ListNode MergeKLists(ListNode[] lists)
            {
                var pq = new PriorityQueue<ListNode, int>();

                foreach (var list in lists)
                {
                    if (list != null)
                    {
                        pq.Enqueue(list, list.val);
                    }
                }

                ListNode dummy = new ListNode(0);
                ListNode current = dummy;

                while (pq.Count > 0)
                {
                    ListNode node = pq.Dequeue();

                    current.next = node;
                    current = current.next;

                    if (node.next != null)
                    {
                        pq.Enqueue(node.next, node.next.val);
                    }
                }

                return dummy.next;
            }
        }
    }
}
