/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
                var slow = head;
        var fast = head;
        ListNode prev = null;

        //reverse first half of the list
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            ListNode next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }

        //if list has odd number of elements skip middle element
        if (fast != null)
            slow = slow.next;
        
        //compare first and second half of the list
        while (slow != null)
        {
            if (slow.val != prev.val)
                return false;

            slow = slow.next;
            prev = prev.next;
        }

        return true;
    }
}
