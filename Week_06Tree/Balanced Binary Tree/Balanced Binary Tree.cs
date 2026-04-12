using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Balanced_Binary_Tree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheckHeight(root) != -1;
        }

        private int CheckHeight(TreeNode node)
        {
            if (node == null)
                return 0;

            int leftHeight = CheckHeight(node.left);
            if (leftHeight == -1)
                return -1;

            int rightHeight = CheckHeight(node.right);
            if (rightHeight == -1)
                return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
