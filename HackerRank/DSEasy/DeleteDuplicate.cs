namespace DS
{
    internal class DeleteDuplicate
    {
        public static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode llist)
        {
            if (llist == null)
                return llist;
            SinglyLinkedListNode prev = llist;
            SinglyLinkedListNode cur = llist.next;

            while (cur != null)
            {
                if(cur.data == prev.data)
                {
                    prev.next = cur.next;
                }
                else
                {
                    prev.next = cur;
                    prev = cur;
                }
                cur = cur.next;
            }

            return ReverseLinkedList(llist);
        }

        static SinglyLinkedListNode ReverseLinkedList(SinglyLinkedListNode llist)
        {
            SinglyLinkedListNode prev = llist;
            SinglyLinkedListNode cur = llist.next;
            while(cur != null)
            {
                var temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
            }

            return prev;
        }
    }

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;
    }

}
