using System;

namespace c_sharp {

    class RemoveListFromEnd {

        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            ListNode fast = head;
            ListNode slowHead = new ListNode();
            slowHead.next = head;
            ListNode newHead = slowHead;
            int cursor = 1;
            while(cursor < n) {
                fast = fast.next;
                cursor++;
            }

            while(fast.next != null) {
                fast = fast.next;
                slowHead = slowHead.next;
            }

            slowHead.next = slowHead.next.next;
            return newHead.next;
        }

        public void PrintList(ListNode l) {
            string s = "";
            while(l != null) {
                s += l.data;
                l = l.next;
            }
            Console.WriteLine(s);
        }

    }

}