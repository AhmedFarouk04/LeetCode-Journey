using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week04_Binary_Search___Sorting.Magnetic_Force_Between_Two_Balls
{
    public class Magnetic_Force_Between_Two_Balls
    {
        public int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);

            int left = 1;

            int right = position[position.Length - 1] - position[0];

            int answer = 0;

            //  Binary Search
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (CanPlace(position, m, mid))
                {
                    answer = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return answer;
        }

        //Check 
        private bool CanPlace(int[] position, int m, int dist)
        {
            int count = 1;                //first ball 
            int last = position[0];       // position 

            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - last >= dist)
                {
                    count++;
                    last = position[i];

                    if (count == m)
                        return true;
                }
            }

            return false;
        }
    }
}
