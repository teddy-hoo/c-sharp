using System;

namespace c_sharp {
  public class ListNode {
    public int data;
    public ListNode next;
    public ListNode arbitary;
  }

  public class CloneList {
    public ListNode DoClone (ListNode head) {
      ListNode newHead = CloneMainPath (head);
      TransLink1 (head, newHead);
      TransLink2 (newHead);
      return newHead;
    }

    public ListNode CloneMainPath (ListNode head) {
      ListNode newHead = new ListNode ();
      ListNode cursor = newHead;
      while (head != null) {
        ListNode newNode = new ListNode ();
        newNode.data = head.data;
        cursor.next = newNode;
        cursor = newNode;
        head = head.next;
      }
      return newHead.next;
    }

    public void TransLink1 (ListNode head, ListNode newHead) {
      ListNode cursor1 = head;
      ListNode cursor2 = newHead;
      while (cursor1 != null) {
        ListNode tmp = cursor1.next;
        cursor1.next = cursor2;
        cursor2.arbitary = cursor1.arbitary;
        cursor1 = tmp;
        cursor2 = cursor2.next;
      }
    }

    public void TransLink2 (ListNode head) {
      ListNode cursor = head;
      while (cursor != null) {
        if (cursor.arbitary == null) {
          cursor = cursor.next;
          continue;
        }
        cursor.arbitary = cursor.arbitary.next;
        cursor = cursor.next;
      }
    }

    public void PrintList (ListNode head) {
      while (head != null) {
        string next = head.next == null ? "" : "" + head.next.data;
        string arbitary = head.arbitary == null ? "" : "" + head.arbitary.data;
        Console.WriteLine ("" + head.data + " " + next + " " + arbitary);
        head = head.next;
      }
    }
  }

}