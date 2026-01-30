using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Binary_Search
{
    public  class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    l = mid + 1;
                else
                    r = mid - 1;
            }

            return -1;
        }
    }
}
