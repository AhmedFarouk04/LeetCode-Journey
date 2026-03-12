using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_05Linked_List.Intersection_of_Two_Linked_Lists
{
    public class InsertInTwoList
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

            ListNode pA = headA;
            ListNode pB = headB;

            while (pA != pB)
            {
                pA = (pA == null) ? headB : pA.next;
                pB = (pB == null) ? headA : pB.next;
            }

            return pA;
        }
    }
}
