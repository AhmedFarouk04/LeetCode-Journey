using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Heap
{
      public class Sort_Characters_By_Frequency
    {


public class Solution
{
    public string FrequencySort(string s)
    {
        var freq = new Dictionary<char, int>();

        
        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;

            freq[c]++;
        }

        var pq = new PriorityQueue<char, int>();

       
        foreach (var item in freq)
        {
            pq.Enqueue(item.Key, -item.Value);
        }

        var result = new StringBuilder();

        
        while (pq.Count > 0)
        {
            char ch = pq.Dequeue();
            int count = freq[ch];

            for (int i = 0; i < count; i++)
            {
                result.Append(ch);
            }
        }

        return result.ToString();
    }
}



       }
}
