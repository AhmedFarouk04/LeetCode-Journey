using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_05Linked_List.Remove_NTH_Item_from_the_last
{
    internal class RemooveNthFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            ListNode dummy = new ListNode(0, head);
            ListNode slow = dummy;
            ListNode fast = dummy;

            for (int i = 0; i <= n; i++)
                fast = fast.next;

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}
