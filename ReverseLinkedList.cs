// Definition for a Linked List node
// class ListNode
// {
//     public int val;
//     public ListNode next;

//     // Constructor
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

using System;
using System.Collections.Generic;

public class Solution {
    public static ListNode Reverse(ListNode head) 
    {
        ListNode prev = null;
        var curr = head;
        var next = curr.next;
        
        while(curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        return prev;
    }
}