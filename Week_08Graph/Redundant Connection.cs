using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_08Graph
{
    public class Redundant_Connection
    {
        public class Solution
        {
            public int[] FindRedundantConnection(int[][] edges)
            {
                int n = edges.Length;

                int[] parent = new int[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    parent[i] = i;
                }

                foreach (int[] edge in edges)
                {
                    int a = edge[0];
                    int b = edge[1];

                    if (Find(parent, a) == Find(parent, b))
                    {
                        return edge;
                    }

                    Union(parent, a, b);
                }

                return new int[0];
            }

            private int Find(int[] parent, int node)
            {
                if (parent[node] != node)
                {
                    parent[node] = Find(parent, parent[node]);
                }

                return parent[node];
            }

            private void Union(int[] parent, int a, int b)
            {
                int rootA = Find(parent, a);
                int rootB = Find(parent, b);

                parent[rootB] = rootA;
            }
        }
    }
}
