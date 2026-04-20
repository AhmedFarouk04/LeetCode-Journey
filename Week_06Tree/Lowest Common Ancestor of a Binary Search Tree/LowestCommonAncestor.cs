using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Lowest_Common_Ancestor_of_a_Binary_Search_Tree
{
    public  class LowestCommonAncestor
    {
        public class Solution
        {
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                if (p.val < root.val && q.val < root.val)
                    return LowestCommonAncestor(root.left, p, q);

                if (p.val > root.val && q.val > root.val)
                    return LowestCommonAncestor(root.right, p, q);

                return root;
            }
        }
    }
}
