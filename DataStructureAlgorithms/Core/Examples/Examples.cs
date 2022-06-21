using System;
using System.Linq;
using DataStructureAlgorithms.Core.BinaryTree;

namespace DataStructureAlgorithms.Core.Examples
{
    public static class Examples
    {
        public static void BinarySearch()
        {
            var nums = new[] {1, 4, 6, 12, 24, 85, 124, 125, 128, 422, 1244};
            var binaryTree = new BinaryTree.BinaryTree();
            var result = binaryTree.RBinarySearch(nums, 422);
            Console.WriteLine(result);
        }

        public static void BinaryTreeSearch()
        {
            // defining our sample tree
            var node1 = new Node(1);
            var node2 = new Node(4);
            var node3 = new Node(6);
            var node4 = new Node(9);
            var node5 = new Node(3);
            var node6 = new Node(8);
            var root = new Node(5);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var nodes = new [] {node1, node2, node3, node4, node5, node6, root};

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.RBinaryTreeSearch(root, 3);
            
            if (result == null)
                Console.WriteLine(-1);
            else
                Console.WriteLine($"{result.LeftChild?.Value}|{result.Value}|{result.RightChild?.Value}");
        }

        public static void DepthFirstValues()
        {
            // defining our sample tree
            var node1 = new Node(1);
            var node2 = new Node(4);
            var node3 = new Node(6);
            var node4 = new Node(9);
            var node5 = new Node(3);
            var node6 = new Node(8);
            var root = new Node(5);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var nodes = new [] {node1, node2, node3, node4, node5, node6, root};

            var binaryTree = new BinaryTree.BinaryTree();

            var depthFirstValues = binaryTree.RDepthFirstValues(root);
            if (depthFirstValues != null)
            {
                var result = depthFirstValues.Aggregate("[", (current, node) => current + (node.Value + ", "));
                result = result.Remove(result.Length - 2, 2);
                result += "]";
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("[]");
        }

        public static void BreadthFirstValues()
        {
            // defining our sample tree
            var node1 = new Node(4);
            var node2 = new Node(5);
            var node3 = new Node(6);
            var node4 = new Node(7);
            var node5 = new Node(2);
            var node6 = new Node(3);
            var root = new Node(1);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var binaryTree = new BinaryTree.BinaryTree();

            var breadthFirstValues = binaryTree.RBreadthFirstValues(root);
            if (breadthFirstValues != null)
            {
                var result = breadthFirstValues.Aggregate("[", (current, node) => current + (node.Value + ", "));
                result = result.Remove(result.Length - 2, 2);
                result += "]";
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("[]");
        }

        public static void BinaryTreeSum()
        {
            // defining our sample tree
            var node1 = new Node(4);
            var node2 = new Node(5);
            var node3 = new Node(6);
            var node4 = new Node(7);
            var node5 = new Node(2);
            var node6 = new Node(3);
            var root = new Node(1);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.RBinaryTreeSum(root);
            Console.WriteLine($"{nameof(BinaryTreeSum)}: {result}");
        }

        public static void BinaryTreeMin()
        {
            // defining our sample tree
            var node1 = new Node(4);
            var node2 = new Node(15);
            var node3 = new Node(6);
            var node4 = new Node(12);
            var node5 = new Node(11);
            var node6 = new Node(3);
            var root = new Node(5);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.RBinaryTreeMin(root);
            Console.WriteLine($"{nameof(BinaryTreeMin)}: {result}");
        }

        public static void BinaryTreeMax()
        {
            // defining our sample tree
            var node1 = new Node(4);
            var node2 = new Node(15);
            var node3 = new Node(6);
            var node4 = new Node(12);
            var node5 = new Node(11);
            var node6 = new Node(3);
            var root = new Node(5);

            node1.LeftChild = null;
            node1.RightChild = null;

            node2.LeftChild = null;
            node2.RightChild = null;

            node3.LeftChild = null;
            node3.RightChild = null;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.LeftChild = node3;
            node6.RightChild = node4;

            root.LeftChild = node5;
            root.RightChild = node6;

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.RBinaryTreeMax(root);
            Console.WriteLine($"{nameof(BinaryTreeMin)}: {result}");
        }

        public static void BinaryTreeMaxPathSum()
        {
            /*
             *          1
             *         / \
             *        2   3
             *       / \   \
             *      4   5   6
             *         / \
             *        7   8
             */
            
            // defining our sample tree
            var root = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);
            var node8 = new Node(8);

            root.LeftChild = node2;
            root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = null;
            node3.RightChild = node6;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node7;
            node5.RightChild = node8;

            node6.LeftChild = null;
            node6.RightChild = null;

            node7.LeftChild = null;
            node7.RightChild = null;

            node8.LeftChild = null;
            node8.RightChild = null;

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.BinaryTreeMaxPathSum(root);
            Console.WriteLine($"{nameof(BinaryTreeMaxPathSum)}: {result}");
        }

        public static void BinaryTreeMinPathSum()
        {
            /*
             *          1
             *         / \
             *        2   3
             *       / \   \
             *      4   5   6
             *         / \
             *        7   8
             */
            
            // defining our sample tree
            var root = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);
            var node8 = new Node(8);

            root.LeftChild = node2;
            root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = null;
            node3.RightChild = node6;

            node4.LeftChild = null;
            node4.RightChild = null;

            node5.LeftChild = node7;
            node5.RightChild = node8;

            node6.LeftChild = null;
            node6.RightChild = null;

            node7.LeftChild = null;
            node7.RightChild = null;

            node8.LeftChild = null;
            node8.RightChild = null;

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.BinaryTreeMinPathSum(root);
            Console.WriteLine($"{nameof(BinaryTreeMinPathSum)}: {result}");
        }
    }
}