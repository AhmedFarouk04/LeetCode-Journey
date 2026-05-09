using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_07Heap
{
    public  class Task_Scheduler
    {
        public class Solution
        {
            public int LeastInterval(char[] tasks, int n)
            {
                var freq = new Dictionary<char, int>();

                foreach (char task in tasks)
                {
                    if (!freq.ContainsKey(task))
                        freq[task] = 0;

                    freq[task]++;
                }

                var pq = new PriorityQueue<int, int>();

                foreach (var item in freq)
                {
                    pq.Enqueue(item.Value, -item.Value);
                }

                int time = 0;

                while (pq.Count > 0)
                {
                    int cycle = n + 1;
                    var temp = new List<int>();

                    while (cycle > 0 && pq.Count > 0)
                    {
                        int count = pq.Dequeue();
                        count--;

                        if (count > 0)
                            temp.Add(count);

                        time++;
                        cycle--;
                    }

                    foreach (int count in temp)
                    {
                        pq.Enqueue(count, -count);
                    }

                    if (pq.Count == 0)
                        break;

                    time += cycle;
                }

                return time;
            }
        }
    }
}
