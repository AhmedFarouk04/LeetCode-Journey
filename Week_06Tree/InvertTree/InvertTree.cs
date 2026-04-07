using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.InvertTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            // swap
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            // recurse
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
