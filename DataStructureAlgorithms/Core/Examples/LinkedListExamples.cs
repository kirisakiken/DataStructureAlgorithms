using System;
using DataStructureAlgorithms.Core.LinkedList;

namespace DataStructureAlgorithms.Core.Examples
{
    public static class LinkedListExamples
    {
        public static void LinkedListTraversal()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();
            
            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            linkedListAlgorithms.LinkedListTraversal(head);
        }

        public static void RecursiveLinkedListTraversal()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();
            
            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            linkedListAlgorithms.RLinkedListTraversal(head, "");
        }

        public static void RecursiveLinkedListValues()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();

            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            var nodes = linkedListAlgorithms.RLinkedListValues(null, head);
            var res = "[ ";
            foreach (var node in nodes)
            {
                res += node.Value + ", ";
            }
            res += " ]";

            Console.WriteLine(res);
        }

        public static void RecursiveLinkedListSum()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();

            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            var result = linkedListAlgorithms.RLinkedListSum(head);
            Console.WriteLine(result);
        }

        public static void RecursiveLinkedListFind()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();

            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            var res = linkedListAlgorithms.RLinkedListFind(3, head);
            Console.WriteLine(res?.Value);
        }

        public static void RecursiveLinkedListGetValue()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();

            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            var res = linkedListAlgorithms.RLinkedListGetValue(head, 2);
            Console.WriteLine(res);
        }

        public static void LinkedListReverse()
        {
            var linkedListAlgorithms = new LinkedListAlgorithms();

            var tail = new Node(4);
            var third = new Node(tail, 3);
            var second = new Node(third, 2);
            var head = new Node(second, 1);

            var newHead = linkedListAlgorithms.LinkedListReverse(head);

            var val = linkedListAlgorithms.RLinkedListValues(null, newHead);

            var res = "[ ";
            foreach (var node in val)
            {
                res += node.Value + ", ";
            }
            res += " ]";

            Console.WriteLine(res);
        }
    }
}