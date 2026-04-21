using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Binary_Tree_Right_Side_View
{
    public class RightSideView
    {
        public class Solution
        {
            public IList<int> RightSideView(TreeNode root)
            {
                var result = new List<int>();
                if (root == null) return result;

                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int size = queue.Count;

                    for (int i = 0; i < size; i++)
                    {
                        var node = queue.Dequeue();

                        if (i == size - 1)
                            result.Add(node.val);

                        if (node.left != null) queue.Enqueue(node.left);
                        if (node.right != null) queue.Enqueue(node.right);
                    }
                }

                return result;
            }
        }
    }
}
