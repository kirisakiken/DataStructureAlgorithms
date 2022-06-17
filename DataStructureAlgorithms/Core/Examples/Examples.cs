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
            var node7 = new Node(5);

            node1.Parent = node5;
            node1.LeftChild = null;
            node1.RightChild = null;

            node2.Parent = node5;
            node2.LeftChild = null;
            node2.RightChild = null;

            node3.Parent = node6;
            node3.LeftChild = null;
            node3.RightChild = null;

            node4.Parent = node6;
            node4.LeftChild = null;
            node4.RightChild = null;

            node5.Parent = node7;
            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.Parent = node7;
            node6.LeftChild = node3;
            node6.RightChild = node4;

            node7.Parent = null;
            node7.LeftChild = node5;
            node7.RightChild = node6;

            var nodes = new [] {node1, node2, node3, node4, node5, node6, node7};

            var binaryTree = new BinaryTree.BinaryTree();

            var result = binaryTree.RBinaryTreeSearch(node2, 3);
            
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
            var node7 = new Node(5);

            node1.Parent = node5;
            node1.LeftChild = null;
            node1.RightChild = null;

            node2.Parent = node5;
            node2.LeftChild = null;
            node2.RightChild = null;

            node3.Parent = node6;
            node3.LeftChild = null;
            node3.RightChild = null;

            node4.Parent = node6;
            node4.LeftChild = null;
            node4.RightChild = null;

            node5.Parent = node7;
            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.Parent = node7;
            node6.LeftChild = node3;
            node6.RightChild = node4;

            node7.Parent = null;
            node7.LeftChild = node5;
            node7.RightChild = node6;

            var nodes = new [] {node1, node2, node3, node4, node5, node6, node7};

            var binaryTree = new BinaryTree.BinaryTree();

            var depthFirstValues = binaryTree.RDepthFirstValues(node3);
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
            var node7 = new Node(1);

            node1.Parent = node5;
            node1.LeftChild = null;
            node1.RightChild = null;

            node2.Parent = node5;
            node2.LeftChild = null;
            node2.RightChild = null;

            node3.Parent = node6;
            node3.LeftChild = null;
            node3.RightChild = null;

            node4.Parent = node6;
            node4.LeftChild = null;
            node4.RightChild = null;

            node5.Parent = node7;
            node5.LeftChild = node1;
            node5.RightChild = node2;

            node6.Parent = node7;
            node6.LeftChild = node3;
            node6.RightChild = node4;

            node7.Parent = null;
            node7.LeftChild = node5;
            node7.RightChild = node6;

            var binaryTree = new BinaryTree.BinaryTree();

            var breadthFirstValues = binaryTree.RBreadthFirstValues(node3);
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
    }
}