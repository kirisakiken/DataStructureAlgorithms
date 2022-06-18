using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Xml.XPath;
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
            var root = startNode.GetRoot();
            if (root == null)
                return null;

            var arr = new List<Node>();
            var stack = new List<Node>();

            if (startNode != null)
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
        public List<Node> DepthFirstValues(Node startNode)
        {
            var root = startNode.GetRoot();
            if (root == null)
                return null;

            var arr = new List<Node>();
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

        /// <summary>
        ///     Recursive Breadth First Values Algorithm
        /// </summary>
        public List<Node> RBreadthFirstValues(Node startNode)
        {
            var result = new List<Node>();
            var queue = new Queue<Node>();

            var root = startNode?.GetRoot();
            if (root == null)
                return null;

            queue.Enqueue(startNode.GetRoot());
            return BreadthFirstNodes(result, queue);
        }

        /// <summary>
        ///     Breadth First Values Algorithm
        /// </summary>
        public List<Node> BreadthFirstValues(Node startNode)
        {
            var current = startNode.GetRoot();
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
        public int RBinaryTreeSum(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var sum = 0;
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            return BinaryNodeSum(sum, queue);
        }

        /// <summary>
        ///     Binary Tree Sum Algorithm
        /// </summary>
        public int BinaryTreeSum(Node startNode)
        {
            var current = startNode.GetRoot();
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
        ///     Recursive Binary Tree Minimum Algorithm
        /// </summary>
        public int RBinaryTreeMin(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var min = current.Value;
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            return BinaryMinNode(min, queue);
        }

        /// <summary>
        ///     Binary Tree Minimum Algorithm
        /// </summary>
        public int BinaryTreeMin(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var min = current.Value;
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
        ///     Recursive Binary Tree Max Path Algorithm with Breadth First Search
        /// </summary>
        public int RBfsBinaryTreeMaxPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var queue = new Queue<Node>();
            var result = int.MinValue;

            queue.Enqueue(current);
            return BfsBinaryMaxNodePath(result, queue);
        }

        /// <summary>
        ///     Binary Tree Max Path Algorithm with Breadth First Search
        /// </summary>
        public int BfsBinaryTreeMaxPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var queue = new Queue<Node>();
            var result = int.MinValue;

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                if (!current.IsLeaf())
                {
                    if (current.LeftChild != null)
                        queue.Enqueue(current.LeftChild);

                    if (current.RightChild != null)
                        queue.Enqueue(current.RightChild);

                    continue;
                }

                var pathSum = 0;
                while (!current.IsRoot())
                {
                    pathSum += current.Value;
                    current = current.Parent;
                }
                pathSum += current.Value;

                if (pathSum >= result)
                    result = pathSum;
            }

            return result;
        }

        /// <summary>
        ///     Recursive Binary Tree Max Path Algorithm with Depth First Search
        /// </summary>
        public int RDfsBinaryTreeMaxPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MinValue;
            var stack = new Stack<Node>();
            stack.Push(current);

            return RfsBinaryMaxNodePath(result, stack);
        }

        /// <summary>
        ///     Binary Tree Max Path Algorithm with Depth First Search
        /// </summary>
        public int DfsBinaryTreeMaxPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MinValue;
            var stack = new Stack<Node>();

            stack.Push(current);
            while (stack.Count > 0)
            {
                current = stack.Pop();

                if (!current.IsLeaf())
                {
                    if (current.RightChild != null)
                        stack.Push(current.RightChild);

                    if (current.LeftChild != null)
                        stack.Push(current.LeftChild);

                    continue;
                }

                var pathSum = 0;
                while (!current.IsRoot())
                {
                    pathSum += current.Value;
                    current = current.Parent;
                }
                pathSum += current.Value;

                if (pathSum > result)
                    result = pathSum;
            }

            return result;
        }

        /// <summary>
        ///     Recursive Binary Tree Min Path Algorithm with Depth First Search
        /// </summary>
        public int RDfsBinaryTreeMinPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MaxValue;
            var stack = new Stack<Node>();
            stack.Push(current);

            return DfsBinaryMinNodePath(result, stack);
        }

        /// <summary>
        ///     Binary Tree Min Path Algorithm with Depth First Search
        /// </summary>
        public int DfsBinaryTreeMinPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MaxValue;
            var stack = new Stack<Node>();

            stack.Push(current);
            while (stack.Count > 0)
            {
                current = stack.Pop();

                if (!current.IsLeaf())
                {
                    if (current.RightChild != null)
                        stack.Push(current.RightChild);

                    if (current.LeftChild != null)
                        stack.Push(current.LeftChild);

                    continue;
                }

                var pathSum = 0;
                while (!current.IsRoot())
                {
                    pathSum += current.Value;
                    current = current.Parent;
                }
                pathSum += current.Value;

                if (pathSum < result)
                    result = pathSum;
            }

            return result;
        }

        /// <summary>
        ///     Recursive Binary Tree Min Path Algorithm with Breadth First Search
        /// </summary>
        public int RBfsBinaryTreeMinPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MaxValue;
            var queue = new Queue<Node>();
            queue.Enqueue(current);

            return BfsBinaryMinNodePath(result, queue);
        }

        /// <summary>
        ///     Binary Tree Min Path Algorithm with Breadth First Search
        /// </summary>
        public int BfsBinaryTreeMinPath(Node startNode)
        {
            var current = startNode.GetRoot();
            if (current == null)
                return 0;

            var result = int.MaxValue;
            var queue = new Queue<Node>();

            queue.Enqueue(current);
            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                if (!current.IsLeaf())
                {
                    if (current.LeftChild != null)
                        queue.Enqueue(current.LeftChild);

                    if (current.RightChild != null)
                        queue.Enqueue(current.RightChild);

                    continue;
                }

                var pathSum = 0;
                while (!current.IsRoot())
                {
                    pathSum += current.Value;
                    current = current.Parent;
                }
                pathSum += current.Value;

                if (pathSum < result)
                    result = pathSum;
            }

            return result;
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

        private int BfsBinaryMaxNodePath(int result, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return result;

            var current = queue.Dequeue();
            if (!current.IsLeaf())
            {
                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);

                return BfsBinaryMaxNodePath(result, queue);
            }

            var pathSum = 0;
            var target = current;
            while (!target.IsRoot())
            {
                pathSum += target.Value;
                target = target.Parent;
            }
            pathSum += target.Value;

            if (pathSum > result)
                result = pathSum;

            return BfsBinaryMaxNodePath(result, queue);
        }

        private int RfsBinaryMaxNodePath(int result, Stack<Node> stack)
        {
            if (stack.Count == 0)
                return result;

            var current = stack.Pop();

            if (!current.IsLeaf())
            {
                if (current.RightChild != null)
                    stack.Push(current.RightChild);

                if (current.LeftChild != null)
                    stack.Push(current.LeftChild);

                return RfsBinaryMaxNodePath(result, stack);
            }

            var pathSum = 0;
            while (!current.IsRoot())
            {
                pathSum += current.Value;
                current = current.Parent;
            }
            pathSum += current.Value;

            if (pathSum > result)
                result = pathSum;

            return RfsBinaryMaxNodePath(result, stack);
        }

        private int DfsBinaryMinNodePath(int result, Stack<Node> stack)
        {
            if (stack.Count == 0)
                return result;

            var current = stack.Pop();

            if (!current.IsLeaf())
            {
                if (current.RightChild != null)
                    stack.Push(current.RightChild);

                if (current.LeftChild != null)
                    stack.Push(current.LeftChild);

                return DfsBinaryMinNodePath(result, stack);
            }

            var pathSum = 0;
            while (!current.IsRoot())
            {
                pathSum += current.Value;
                current = current.Parent;
            }
            pathSum += current.Value;

            if (pathSum < result)
                result = pathSum;

            return DfsBinaryMinNodePath(result, stack);
        }

        private int BfsBinaryMinNodePath(int result, Queue<Node> queue)
        {
            if (queue.Count == 0)
                return result;

            var current = queue.Dequeue();

            if (!current.IsLeaf())
            {
                if (current.LeftChild != null)
                    queue.Enqueue(current.LeftChild);

                if (current.RightChild != null)
                    queue.Enqueue(current.RightChild);

                return BfsBinaryMinNodePath(result, queue);
            }

            var pathSum = 0;
            while (!current.IsRoot())
            {
                pathSum += current.Value;
                current = current.Parent;
            }
            pathSum += current.Value;

            if (pathSum < result)
                result = pathSum;

            return BfsBinaryMinNodePath(result, queue);
        }

        #endregion
    }
}