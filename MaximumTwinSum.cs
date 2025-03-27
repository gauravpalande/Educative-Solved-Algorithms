using System;
using System.Collections.Generic;

// Definition of a binary tree node
// public class LinkedListNode<T>
// {
//     public T data;
//     public LinkedListNode<T> next;
// }

class Solution
{
    public static int TwinSum(LinkedListNode<int> head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var curr = slow;
        LinkedListNode<int> prev = null;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        int maxSum = 0;
        curr = head;

        while (prev != null)
        {
            maxSum = Math.Max(maxSum, curr.data + prev.data);
            prev = prev.next;
            curr = curr.next;
        }

        return maxSum;
    }
}