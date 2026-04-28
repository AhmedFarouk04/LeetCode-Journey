using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
      public class Top_K_Frequent_Elements
    {
        public class Solution
        {
            public IList<string> TopKFrequent(string[] words, int k)
            {
                var freq = new Dictionary<string, int>();

                foreach (string word in words)
                {
                    if (!freq.ContainsKey(word))
                        freq[word] = 0;

                    freq[word]++;
                }

                var comparer = Comparer<(int count, string word)>.Create((a, b) =>
                {
                    if (a.count != b.count)
                        return a.count.CompareTo(b.count);

                    return b.word.CompareTo(a.word);
                });

                var pq = new PriorityQueue<string, (int count, string word)>(comparer);

                foreach (var item in freq)
                {
                    pq.Enqueue(item.Key, (item.Value, item.Key));

                    if (pq.Count > k)
                        pq.Dequeue();
                }

                var result = new List<string>();

                while (pq.Count > 0)
                {
                    result.Add(pq.Dequeue());
                }

                result.Reverse();

                return result;
            }
        }
    }
}
