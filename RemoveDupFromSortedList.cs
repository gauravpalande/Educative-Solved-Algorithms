using System;

// Template for linked list node class with generics
// public class LinkedListNode<T>
// {
//     public T data;
//     public LinkedListNode<T> next;
// }

public class Solution
{
    public static LinkedListNode<int> RemoveDuplicates(LinkedListNode<int> head)
    {
        var curr = head;
        
        while(curr != null && curr.next != null)
        {
            if(curr.data == curr.next.data)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }
        
        return head;
    }
}