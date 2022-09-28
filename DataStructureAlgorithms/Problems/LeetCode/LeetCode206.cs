namespace DataStructureAlgorithms.Problems.LeetCode
{
     public class ListNode
     {
         public int Value { get; }
         public ListNode Next { get; set; }

         public ListNode(int val, ListNode next)
         {
             Value = val;
             Next = next;
         }
     }

    /// <summary>
    ///     LeetCode 206 - Reverse Linked List
    ///     https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class LeetCode206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;
            ListNode current = head;
            ListNode next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}