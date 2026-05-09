using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_07Heap
{
    public class Reorganize_String
    {
        public class Solution
        {
            public string ReorganizeString(string s)
            {
                var freq = new Dictionary<char, int>();

                foreach (char c in s)
                {
                    if (!freq.ContainsKey(c))
                        freq[c] = 0;

                    freq[c]++;
                }

                var pq = new PriorityQueue<(char ch, int count), int>();

                foreach (var item in freq)
                {
                    pq.Enqueue((item.Key, item.Value), -item.Value);
                }

                var result = new StringBuilder();

                (char ch, int count) prev = ('#', 0);

                while (pq.Count > 0)
                {
                    var current = pq.Dequeue();

                    result.Append(current.ch);
                    current.count--;

                    if (prev.count > 0)
                    {
                        pq.Enqueue(prev, -prev.count);
                    }

                    prev = current;
                }

                if (result.Length != s.Length)
                    return "";

                return result.ToString();
            }
        }
    }
}
