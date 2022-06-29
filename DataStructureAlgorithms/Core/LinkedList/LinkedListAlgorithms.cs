using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DataStructureAlgorithms.Core.LinkedList
{
    /// <summary>
    ///     Represents a Linked List Node
    ///     Head -> First node
    ///     Tail -> Last node
    /// </summary>
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; }

        public Node(int value)
        {
            Next = null;
            Value = value;
        }

        public Node(Node next, int value)
        {
            Next = next;
            Value = value;
        }
    }

    public class LinkedListAlgorithms
    {
        /// <summary>
        ///     Recursive Linked List Traversal Algorithm
        ///     Prints Linked List
        /// </summary>
        public void RLinkedListTraversal(Node head, string result)
        {
            if (head == null)
            {
                result += " ]";
                Console.WriteLine(result);
                return;
            }

            result += head.Value + ", ";
            RLinkedListTraversal(head.Next, result);
        }

        /// <summary>
        ///     Linked List Traversal Algorithm
        ///     Prints Linked List
        /// </summary>
        public void LinkedListTraversal(Node head)
        {
            var result = "[ ";
            var current = head;

            while (current != null)
            {
                result += current.Value + ", ";
                current = current.Next;
            }

            result += " ]";
            Console.WriteLine(result);
        }

        /// <summary>
        ///     Recursive Linked List Values Algorithm
        /// </summary>
        public List<Node> RLinkedListValues(List<Node> result, Node head)
        {
            if (result == null)
                result = new List<Node>();

            if (head == null)
                return result;

            result.Add(head);
            return RLinkedListValues(result, head.Next);
        }

        /// <summary>
        ///     Recursive Linked List Sum Algorithm
        /// </summary>
        public int RLinkedListSum(Node head, int result = 0)
        {
            if (head == null)
                return result;

            result += head.Value;
            return RLinkedListSum(head.Next, result);
        }

        /// <summary>
        ///     Recursive Linked List Find Algorithm
        /// </summary>
        public Node RLinkedListFind(int target, Node head)
        {
            if (head == null)
                return null;

            if (head.Value == target)
                return head;

            return RLinkedListFind(target, head.Next);
        }

        /// <summary>
        ///     Given index, returns value of node at
        ///     that index from given linked list
        /// </summary>
        public int RLinkedListGetValue(Node head, int targetIndex, int currentIndex = 0)
        {
            if (head == null)
                return 0;

            if (targetIndex == currentIndex)
                return head.Value;

            return RLinkedListGetValue(head.Next, targetIndex, ++currentIndex);
        }

        /// <summary>
        ///     Linked List Reverse Algorithm
        ///     O(n) - time
        ///     O(1) - space
        /// </summary>
        public Node LinkedListReverse(Node head)
        {
            Node previous = null;
            var current = head;

            while (current != null)
            {
                var next = current.Next;

                current.Next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }

        /// <summary>
        ///     Recursive Linked List Reverse Algorithm
        ///     O(n) - time
        ///     O(n) - space
        /// </summary>
        public Node RLinkedListReverse(Node head, Node previous = null)
        {
            if (head == null)
                return previous;

            var next = head.Next;
            return RLinkedListReverse(next, head);
        }

        /// <summary>
        ///     Zipper Linked List Algorithm
        ///     A -> A1 -> A2 -> A3 -> A4
        ///     B -> B1 -> B2
        ///     Result
        ///     A -> B -> A1 -> B1 -> A2 -> B2 -> A3 -> A4
        /// 
        ///     O(min(n, m)) - time
        ///     O(1) - space
        /// </summary>
        public Node ZipperLinkedList(Node headA, Node headB)
        {
            var count = 0;
            var tail = headA;
            var currentA = headA.Next;
            var currentB = headB;

            while (currentA != null && currentB != null)
            {
                if (count % 2 == 0)
                {
                    tail.Next = currentB;
                    currentB = currentB.Next;
                }
                else
                {
                    tail.Next = currentA;
                    currentA = currentA.Next;
                }

                tail = tail.Next;
                ++count;
            }

            if (currentA != null)
                tail.Next = currentA;
            else if (currentB != null)
                tail.Next = currentB;

            return headA;
        }

        /// <summary>
        ///     Recursive Zipper Linked List Algorithm
        /// </summary>
        public Node RZipperLinkedList(Node headA, Node headB)
        {
            if (headA == null && headB == null)
                return null;

            if (headA == null)
                return headB;

            if (headB == null)
                return headA;

            var nextA = headA.Next;
            var nextB = headB.Next;

            headA.Next = headB;
            headB.Next = RZipperLinkedList(nextA, nextB);

            return headA;
        }
    }
}