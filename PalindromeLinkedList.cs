/* Definition for a Linked List node
public class LinkedListNode
{
    public int data;
    public LinkedListNode next;
  
    public LinkedListNode(int data)
    {
        this.data = data;
        this.next = null;
    }
}*/

using System;

public class Solution{
      public static bool Palindrome(LinkedListNode head) {
        LinkedListNode slow = head;
        LinkedListNode fast = head;
        
        while (fast != null && fast.next != null)
        {            
            slow = slow.next;           
            fast = fast.next.next;
        }
        
        LinkedListNode revertData = LinkedListReversal.ReverseLinkedList(slow);     
        bool check = CompareTwoHalves(head, revertData);
        LinkedListReversal.ReverseLinkedList(revertData);

        return check;
    }

    // Function to compare two halves of a linked list
    public static bool CompareTwoHalves(LinkedListNode firstHalf, LinkedListNode secondHalf)
    {        
        while (firstHalf != null && secondHalf != null)
        {
            if (firstHalf.data != secondHalf.data)
            {
                return false;
            }
            else
            {
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }
        }
        return true;
    }
    
    public static LinkedListNode ReverseLinkedList(LinkedListNode slowPtr)
    {
        LinkedListNode prev = null;
        LinkedListNode next = null;
        LinkedListNode curr = slowPtr;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}