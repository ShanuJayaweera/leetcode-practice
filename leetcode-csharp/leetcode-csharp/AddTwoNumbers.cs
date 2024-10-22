using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp
{
    public class AddTwoNumbers
    {


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode Solution(ListNode l1, ListNode l2)
        {
            // create new list node
            ListNode dummyHead = new ListNode();
            ListNode l3 = dummyHead;

            // iterate the linked list
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int l1Val = (l1.val != null) ? l1.val : 0;
                int l2Val = (l2.val != null) ? l2.val : 0;

                int sum = l1Val + l2Val + carry;
                carry = sum / 10; // sum will not > 10 beacause of one digit value. carry is int number. so it is avoid decimals
                int lastDigit = sum % 10; // assume sum is 18. 18 % 10 = 8

                ListNode newNode = new ListNode(lastDigit);
                l3.next = newNode;

                if (l1.next != null) l1 = l1.next;
                if (l2.next != null) l2 = l2.next;
                l3 = l3.next;
            }

            if (carry > 0) 
            {
                ListNode newNode = new ListNode(carry);
                l3.next = newNode;
                l3 = l3.next;
            }

            return dummyHead.next;
        }
    }
}
