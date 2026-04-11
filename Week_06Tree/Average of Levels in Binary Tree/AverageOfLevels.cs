using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Average_of_Levels_in_Binary_Tree
{
    internal class AverageOfLevels
    {
        public IList<double> Average_Of_Levels(TreeNode root)
        {
            var result = new List<double>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                long sum = 0;

                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                result.Add((double)sum / size);
            }

            return result;
        }
    }
}
