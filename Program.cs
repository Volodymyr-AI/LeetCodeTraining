using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace LeetCodeTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            //Input: head = [1, 2, 3, 4, 5]
            //Output: [3,4,5]
            //Explanation: The middle node of the list is node 3.


        }
        //Given the head of a singly linked list, return the middle node of the linked list. If there are two middle nodes, return the second middle node.
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }


        //Result: Time > 30%   Memory > 89%
    }
}