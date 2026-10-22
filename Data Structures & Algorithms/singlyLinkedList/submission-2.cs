public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}
public class LinkedList {
    private ListNode head;
    private ListNode tail;
    private int size;

    public int Get(int index) {
        if ((uint)index >= (uint)size) {
            return -1;
        }

        ListNode curr = head;
        for (int i = 0; i < index; i++)
            curr = curr.next;

        return curr.val;
    }

    public void InsertHead(int val) {
        head = new ListNode(val, head);
        if (tail == null) tail = head; 
        size++;
    }

    public void InsertTail(int val) {
        var node = new ListNode(val);

        if (tail == null)
            head = tail = node;
        else
            tail = tail.next = node;

        size++;
    }

    public bool Remove(int index) {
        if ((uint)index >= (uint)size) return false;

        if (index == 0)
        {
            head = head.next;
            if (head == null) tail = null;
        }
        else
        {
            ListNode prev = head;
            for (int i = 1; i < index; i++)
                prev = prev.next;

            prev.next = prev.next.next;
            if (prev.next == null) tail = prev; 
        }

        size--;
        return true;
    }

    public List<int> GetValues() {
        var result = new List<int>(size);
        for (ListNode curr = head; curr != null; curr = curr.next)
            result.Add(curr.val);

        return result;
    }
}