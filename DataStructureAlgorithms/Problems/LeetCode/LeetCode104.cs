namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 104 - Maximum Depth of Binary Tree
    ///     https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class LeetCode104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            var maxChild = left >= right ? left : right;

            return 1 + maxChild;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}