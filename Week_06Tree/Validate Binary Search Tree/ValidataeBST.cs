using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Validate_Binary_Search_Tree
{
    public  class ValidataeBST
    {
        
            public bool IsValidBST(TreeNode root)
            {
                return Dfs(root, long.MinValue, long.MaxValue);
            }

            private bool Dfs(TreeNode node, long min, long max)
            {
                if (node == null) return true;

                if (node.val <= min || node.val >= max)
                    return false;

                return Dfs(node.left, min, node.val) &&
                       Dfs(node.right, node.val, max);
            }
        }
    }

