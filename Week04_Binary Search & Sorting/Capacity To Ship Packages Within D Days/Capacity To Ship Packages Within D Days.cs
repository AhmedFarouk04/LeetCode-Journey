using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Capacity_To_Ship_Packages_Within_D_Days
{
    public class Capacity_To_Ship_Packages_Within_D_Days
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            int left = 0;
            int right = 0;

            foreach (int w in weights)
            {
                left = Math.Max(left, w);
                right += w;
            }

            int answer = right;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int daysUsed = 1;
                int currentWeight = 0;

                foreach (int w in weights)
                {
                    if (currentWeight + w <= mid)
                    {
                        currentWeight += w;
                    }
                    else
                    {
                        daysUsed++;
                        currentWeight = w;
                    }
                }

                if (daysUsed <= days)
                {
                    answer = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return answer;
        }
    }
}
