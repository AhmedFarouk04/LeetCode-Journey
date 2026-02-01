using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Koko_Eating_Bananas
{
    public  class Koko_Eating_Bananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int l = 1;
            int r = piles.Max();
            int ans = r;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (CanFinish(piles, mid, h))
                {
                    ans = mid;
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return ans;
        }

        private bool CanFinish(int[] piles, int speed, int h)
        {
            long hours = 0;

            foreach (int pile in piles)
            {
                hours += (pile + speed - 1) / speed;
            }

            return hours <= h;
        }

    }
}
