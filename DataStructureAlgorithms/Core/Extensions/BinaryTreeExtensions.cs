using System;
using DataStructureAlgorithms.Core.BinaryTree;

namespace DataStructureAlgorithms.Core.Extensions
{
    public static class BinaryTreeExtensions
    {
        public static bool IsLeaf(this Node self)
        {
            if (self == null)
                throw new InvalidOperationException($"{nameof(Node)} is null");

            return self.LeftChild == null && self.RightChild == null;
        }
    }
}