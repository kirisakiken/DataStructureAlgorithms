using System.Collections.Generic;
using DataStructureAlgorithms.Core.Extensions;

namespace DataStructureAlgorithms.Core.BinaryTree
{
    public class BinaryTree
    {
        #region Public

        /// <summary>
        ///     Recursive Binary Tree Search
        /// </summary>
        public Node RBinaryTreeSearch(Node node, int target)
        {
            return NodeSearch(node.GetRoot(), target);
        }

        /// <summary>
        ///     Binary Tree Search
        /// </summary>
        public Node BinaryTreeSearch(Node startingPoint, int target)
        {
            var pivot = startingPoint.GetRoot();

            while (pivot.Value != target)
            {
                pivot = pivot.Value > target
                    ? pivot.LeftChild
                    : pivot.RightChild;
            }

            return pivot;
        }

        /// <summary>
        ///     Recursive Depth First Values Algorithm
        /// </summary>
        public List<Node> RDepthFirstValues(Node startNode)
        {
            var arr = new List<Node>();
            var root = startNode.GetRoot();
            var stack = new List<Node>();

            if (startNode != null)
                stack.Add(root);

            return DepthFirstNodes(arr, stack);
        }

        /// <summary>
        ///     Depth First Values Algorithm
        /// </summary>
        public List<Node> DepthFirstValues(Node startNode)
        {
            var arr = new List<Node>();
            var root = startNode.GetRoot();
            var stack = new List<Node>();

            if (startNode != null)
                stack.Add(root);

            while (stack.Count > 0)
            {
                var current = stack[stack.Count - 1];
                arr.Add(current);

                stack.RemoveAt(stack.Count - 1);

                if (current.RightChild != null)
                    stack.Add(current.RightChild);

                if (current.LeftChild != null)
                    stack.Add(current.LeftChild);
            }

            return arr;
        }

        #endregion

        #region Private

        private Node NodeSearch(Node node, int target)
        {
            if (node == null)
                return null;

            if (node.Value == target)
                return node;

            return NodeSearch(node.Value > target? node.LeftChild: node.RightChild, target);
        }

        private List<Node> DepthFirstNodes(List<Node> result, List<Node> stack)
        {
            var current = stack[stack.Count - 1];
            result.Add(current);

            stack.RemoveAt(stack.Count - 1);

            if (current.RightChild != null)
                stack.Add(current.RightChild);

            if (current.LeftChild != null)
                stack.Add(current.LeftChild);

            if (stack.Count > 0)
                return DepthFirstNodes(result, stack);

            return result;
        }

        #endregion
    }
}