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

                var pivot = (left + right) / 2;

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
        public Node RBinaryTreeSearch(Node root, int target)
        {
            return NodeSearch(root, target);
        }

        /// <summary>
        ///     Binary Tree Search Algorithm
        /// </summary>
        public Node BinaryTreeSearch(Node root, int target)
        {
            var pivot = root;

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
        public List<Node> RDepthFirstValues(Node root)
        {
            if (root == null)
                return null;

            var arr = new List<Node>();
            var stack = new List<Node>();
            stack.Add(root);

            return DepthFirstNodes(arr, stack);
        }

        /// <summary>
        ///     Depth First Values Algorithm
        /// </summary>
        /// Version with Stack Data Structure type,
        /// var stack = new Stack<!--Node-->>()
        /// stack.Push(current);
        /// while (stack.Count > 0)
        /// {
        ///     current = stack.Pop();
        ///     arr.Add(current);
        ///
        ///     if (current.RightChild != null)
        ///         stack.Push(current.RightChild);
        ///
        ///     if (current.LeftChild != null)
        ///         stack.Push(current.LeftChild);
        /// }
        public List<Node> DepthFirstValues(Node root)
        {
            if (root == null)
                return null;

            var arr = new List<Node>();
            var stack = new List<Node>();
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

        /// <summary>
        ///     Recursive Breadth First Values Algorithm
        /// </summary>
        public List<Node> RBreadthFirstValues(Node root)
        {
            if (root == null)
                return null;

            var result = new List<Node>();
            var queue = new Queue<Node>();

            queue.Enqueue(root);
            return BreadthFirstNodes(result, queue);
        }

        /// <summary>
        ///     Breadth First Values Algorithm
        /// </summary>
        public List<Node> BreadthFirstValues(Node root)
        {
            var current = root;
            if (current == null)
                return null;

            var result = new List<Node>();
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                result.Add(current);

                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);
            }

            return result;
        }

        /// <summary>
        ///     Recursive Binary Tree Sum Algorithm
        /// </summary>
        public int RBinaryTreeSum(Node root)
        {
            if (root == null)
                return 0;

            var sum = 0;
            var queue = new Queue<Node>();

            queue.Enqueue(root);
            return BinaryNodeSum(sum, queue);
        }

        /// <summary>
        ///     Binary Tree Sum Algorithm
        /// </summary>
        public int BinaryTreeSum(Node root)
        {
            var current = root;
            if (current == null)
                return 0;

            var sum = 0;
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                sum += current.Value;

                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);
            }

            return sum;
        }

        /// <summary>
        ///     Recursive Binary Tree Maximum Algorithm
        /// </summary>
        public int RBinaryTreeMax(Node root)
        {
            if (root == null)
                return 0;

            var result = int.MinValue;
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            return BinaryMaxNode(result, queue);
        }

        /// <summary>
        ///     Binary Tree Maximum Algorithm
        /// </summary>
        public int BinaryTreeMax(Node root)
        {
            var current = root;
            if (current == null)
                return 0;

            var result = int.MinValue;
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                current = queue.Dequeue();

                if (current.Value > result)
                    result = current.Value;

                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);
            }

            return result;
        }

        /// <summary>
        ///     Recursive Binary Tree Minimum Algorithm
        /// </summary>
        public int RBinaryTreeMin(Node root)
        {
            if (root == null)
                return 0;

            var min = int.MaxValue;
            var queue = new Queue<Node>();

            queue.Enqueue(root);
            return BinaryMinNode(min, queue);
        }

        /// <summary>
        ///     Binary Tree Minimum Algorithm
        /// </summary>
        public int BinaryTreeMin(Node root)
        {
            var current = root;
            if (current == null)
                return 0;

            var min = int.MaxValue;
            var queue = new Queue<Node>();
            queue.Enqueue(current);

            while (queue.Count > 0)
            {
                current = queue.Dequeue();

                if (min > current.Value)
                    min = current.Value;

                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);
            }

            return min;
        }

        /// <summary>
        ///     Recursive Binary Tree Max Path Sum Algorithm
        /// </summary>
        public int BinaryTreeMaxPathSum(Node root)
        {
            if (root == null)
                return 0;

            if (root.LeftChild == null && root.RightChild == null)
                return root.Value;

            var leftValue = BinaryTreeMaxPathSum(root.LeftChild);
            var rightValue = BinaryTreeMaxPathSum(root.RightChild);
            var maxValue = leftValue >= rightValue
                ? leftValue
                : rightValue;

            return root.Value + maxValue;
        }

        /// <summary>
        ///     Recursive Binary Tree Min Path Sum Algorithm
        /// </summary>
        public int BinaryTreeMinPathSum(Node root)
        {
            if (root == null)
                return 0;

            if (root.LeftChild == null && root.RightChild == null)
                return root.Value;

            var leftValue = BinaryTreeMinPathSum(root.LeftChild);
            var rightValue = BinaryTreeMinPathSum(root.RightChild);
            var minValue = leftValue >= rightValue
                ? rightValue
                : leftValue;

            return root.Value + minValue;
        }

        #endregion

        #region Private

        private int BinarySearch(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;

            var pivot = (left + right) / 2;

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

            return NodeSearch(node.Value > target ? node.LeftChild : node.RightChild, target);
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

        private List<Node> DepthFirstNodes(List<Node> result, Stack<Node> stack)
        {
            if (stack.Count == 0)
                return result;

            var current = stack.Pop();
            result.Add(current);

            if (current.LeftChild != null)
                stack.Push(current.LeftChild);

            if (current.RightChild != null)
                stack.Push(current.RightChild);

            return DepthFirstNodes(result, stack);
        }

        private List<Node> BreadthFirstNodes(List<Node> result, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return result;

            var current = queue.Dequeue();
            result.Add(current);

            if (current.LeftChild != null)
                queue.Enqueue(current.LeftChild);

            if (current.RightChild != null)
                queue.Enqueue(current.RightChild);

            return BreadthFirstNodes(result, queue);
        }

        private int BinaryNodeSum(int sum, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return sum;

            var current = queue.Dequeue();
            sum += current.Value;

            if (current.LeftChild != null)
                queue.Enqueue(current.LeftChild);

            if (current.RightChild != null)
                queue.Enqueue(current.RightChild);

            return BinaryNodeSum(sum, queue);
        }

        private int BinaryMaxNode(int result, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return result;

            var current = queue.Dequeue();

            if (current.Value > result)
                result = current.Value;

            if (current.LeftChild != null)
                queue.Enqueue(current.LeftChild);

            if (current.RightChild != null)
                queue.Enqueue(current.RightChild);

            return BinaryMaxNode(result, queue);
        }

        private int BinaryMinNode(int min, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return min;

            var current = queue.Dequeue();

            if (min > current.Value)
                min = current.Value;

            if (current.LeftChild != null)
                queue.Enqueue(current.LeftChild);

            if (current.RightChild != null)
                queue.Enqueue(current.RightChild);

            return BinaryMinNode(min, queue);
        }

        #endregion
    }
}