using System.Runtime.CompilerServices;

namespace LeetCodeTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test cases
            
       
        }
        //IsSubsequence
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // creating new List where sorted result will be stored
            ListNode head = new ListNode();
            ListNode tail = head;

            while (list1 != null && list2 != null)// iterate through list1 and list2
            {
                if(list1.val <= list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }

            if(list1 != null)
            {
                tail.next = list1;
            }
            else
            {
                tail.next = list2;
            }
            return head.next;
        }

        //Result: 
    }
}