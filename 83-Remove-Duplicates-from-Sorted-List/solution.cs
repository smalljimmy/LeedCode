/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        
        
        ListNode result = new ListNode(head.val);
        ListNode pre = result;
        
        if (head == null)
        {
            return null;
        }
        
        while (head != null)
        {
            if (pre.val == head.val)
            {
                head = head.next;
            }
            else
            {
                pre.next = new ListNode(head.val);
                pre = pre.next;
                head = head.next;
            }
        }
        
        return result;
        
    }
}