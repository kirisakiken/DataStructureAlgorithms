using DataStructureAlgorithms.Core.BinaryTree;

namespace DataStructureAlgorithms.Core.Extensions
{
    public static class BinaryTreeExtensions
    {
        public static bool IsRoot(this Node self) => self?.Parent == null;

        public static bool IsLeaf(this Node self) => self?.LeftChild == null && self?.RightChild == null;

        public static Node GetRoot(this Node node)
        {
            while (!node.IsRoot())
                return GetRoot(node.Parent);

            return node;
        }
    }
}