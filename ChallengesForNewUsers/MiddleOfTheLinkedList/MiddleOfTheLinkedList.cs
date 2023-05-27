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
    public ListNode MiddleNode(ListNode head) {
        ListNode single = head;
        int listLength = 1;
        if (head.next != null) {

        
        ListNode doubleN = head.next;
        while(doubleN.next != null) {
            single = single.next;
            doubleN = doubleN.next;
            listLength += 1;
            if (doubleN.next != null) {
                doubleN = doubleN.next;
                listLength += 1;
            }
        }
        if (listLength % 2 == 1) {
            return single.next;
        } else {
            return single;
        }}
        else {
            return head;
        }
        
    }
}