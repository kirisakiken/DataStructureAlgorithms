using System;
using System.Collections.Generic;
using DataStructureAlgorithms.Core.Extensions;

namespace DataStructureAlgorithms.Core.BinaryTree
{
    public class BinaryTree
    {
        #region Public

        /// <summary>
        ///     Resursive Binary Search Algorithm
        /// </summary>
        public int RBinarySearch(int[] arr, int target)
        {
            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        /// <summary>
        ///     Binary Search Algorithm
        /// </summary>
        public int BinarySearch(int[] arr, int target)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (true)
            {
                if (left > right)
                    return -1;

                var pivot = (int) Math.Floor((decimal) (left + right) / 2);

                if (arr[pivot] == target)
                    return pivot;

                if (arr[pivot] > target)
                {
                    right = pivot - 1;
                    continue;
                }

                if (arr[pivot] < target)
                {
                    left = pivot + 1;
                    continue;
                }
            }
        }

        /// <summary>
        ///     Recursive Binary Tree Search Algorithm
        /// </summary>
        public Node RBinaryTreeSearch(Node node, int target)
        {
            return NodeSearch(node.GetRoot(), target);
        }

        /// <summary>
        ///     Binary Tree Search Algorithm
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

        private int BinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;

            var pivot = (int) Math.Floor((decimal) (left + right) / 2);

            if (arr[pivot] == target)
                return pivot;

            if (arr[pivot] > target)
                return BinarySearch(arr, target, left, pivot - 1);

            if (arr[pivot] < target)
                return BinarySearch(arr, target, pivot + 1, right);

            return 0;
        }

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