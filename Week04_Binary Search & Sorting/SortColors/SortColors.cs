using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.SortColors
{
    public class SortColors
    {
        public class Solution
        {
            public void SortColors(int[] nums)
            {
                int low = 0;
                int mid = 0;
                int high = nums.Length - 1;

                while (mid <= high)
                {
                    if (nums[mid] == 0)
                    {
                        int temp = nums[low];
                        nums[low] = nums[mid];
                        nums[mid] = temp;
                        low++;
                        mid++;
                    }
                    else if (nums[mid] == 1)
                    {
                        mid++;
                    }
                    else
                    {
                        int temp = nums[mid];
                        nums[mid] = nums[high];
                        nums[high] = temp;
                        high--;
                    }
                }
            }
        }

    }
}
