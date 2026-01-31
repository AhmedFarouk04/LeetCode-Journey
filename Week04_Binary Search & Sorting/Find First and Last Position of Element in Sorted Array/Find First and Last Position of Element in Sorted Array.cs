using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public  class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = FindFirst(nums, target);
            int last = FindLast(nums, target);
            return new int[] { first, last };
        }

        private int FindFirst(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            int ans = -1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] >= target)
                    r = mid - 1;
                else
                    l = mid + 1;

                if (nums[mid] == target)
                    ans = mid;
            }

            return ans;
        }

        private int FindLast(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            int ans = -1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] <= target)
                    l = mid + 1;
                else
                    r = mid - 1;

                if (nums[mid] == target)
                    ans = mid;
            }

            return ans;
        }

    }
}
