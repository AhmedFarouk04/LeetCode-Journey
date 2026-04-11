using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Diameter_of_Binary_Tree
{
    public class Solution
    {
        private int diameter = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Height(root);
            return diameter;
        }

        private int Height(TreeNode node)
        {
            if (node == null)
                return 0;

            int leftHeight = Height(node.left);
            int rightHeight = Height(node.right);

            diameter = Math.Max(diameter, leftHeight + rightHeight);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
