using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_06Tree.Path_Sum_II
{
   public  class Path_Sum_II
    {

        
            public IList<IList<int>> PathSum(TreeNode root, int targetSum)
            {
                var result = new List<IList<int>>();
                var path = new List<int>();

                Dfs(root, targetSum, path, result);

                return result;
            }

            private void Dfs(TreeNode node, int targetSum, List<int> path, List<IList<int>> result)
            {
                if (node == null)
                    return;

                path.Add(node.val);

                if (node.left == null && node.right == null && targetSum == node.val)
                {
                    result.Add(new List<int>(path));
                }
                else
                {
                    Dfs(node.left, targetSum - node.val, path, result);
                    Dfs(node.right, targetSum - node.val, path, result);
                }

                path.RemoveAt(path.Count - 1); // backtrack
            }
        }
    }

