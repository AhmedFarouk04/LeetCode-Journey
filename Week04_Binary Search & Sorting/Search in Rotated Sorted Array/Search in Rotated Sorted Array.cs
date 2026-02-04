using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Search_in_Rotated_Sorted_Array
{
    public  class Search_in_Rotated_Sorted_Array
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] == target) return mid;

                if (nums[l] <= nums[mid])
                {
                    if (nums[l] <= target && target < nums[mid])
                        r = mid - 1;
                    else
                        l = mid + 1;
                }
                else
                {
                    if (nums[mid] < target && target <= nums[r])
                        l = mid + 1;
                    else
                        r = mid - 1;
                }
            }

            return -1;
        }

    }
}
