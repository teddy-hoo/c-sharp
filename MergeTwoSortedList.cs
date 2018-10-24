using System;

namespace c_sharp {

  public class Node {
    public int data;
    public Node next;
  }

  public class MergeList {

    public Node Merge (Node head1, Node head2) {
      Node newHead = new Node ();
      Node cursor = newHead;
      while (head1 != null && head2 != null) {
        if (head1.data <= head2.data) {
          cursor.next = head1;
          head1 = head1.next;
        } else {
          cursor.next = head2;
          head2 = head2.next;
        }
        cursor = cursor.next;
      }
      cursor.next = head1 != null ? head1 : head2;
      return newHead.next;
    }

    public void PrintList (Node list) {
      while (list != null) {
        Console.WriteLine ("" + list.data);
        list = list.next;
      }
    }

  }

}