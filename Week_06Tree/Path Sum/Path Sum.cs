using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Path_Sum
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null)
                return targetSum == root.val;

            return HasPathSum(root.left, targetSum - root.val) ||
                   HasPathSum(root.right, targetSum - root.val);
        }
    }
}
