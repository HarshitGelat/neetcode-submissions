public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val) {
        this.val = val;
        this.next = null;
    }
}
public class LinkedList {
    private ListNode head;
    private ListNode tail;

    private int size;

    public LinkedList() {
        head = null;
        tail = null;
        size = 0;
    }

    public int Get(int index) {
        if (index < 0 || index >= size) {
            return -1;
        }

        ListNode curr = head;
        int currIndex = 0;

        while (currIndex < index) {
            curr = curr.next;
            currIndex++;
        }

        return curr.val;
    }

    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);
        newNode.next = head;
        head = newNode;

        if (size == 0) {
            tail = newNode;
        }

        size++;
    }

    public void InsertTail(int val) {
        ListNode newNode = new ListNode(val);

        if (size == 0) {
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }

        size++;
    }

    public bool Remove(int index) {
        if (index < 0 || index >= size) {
            return false;
        }

        if (index == 0) {
            head = head.next;

            if (head == null) {
                tail = null;
            }
            size--;
            return true;
        }

        ListNode curr = head;
        int currIndex = 0;

        while (currIndex < index - 1) {
            curr = curr.next;
            currIndex++;
        }

        if (index == size - 1) {
            curr.next = null;
            tail = curr;
        } else {
            ListNode skip = curr.next;
            curr.next = skip.next;
        }

        size--;
        return true;
    }

    public List<int> GetValues() {
        List<int> result = new List<int>();
        ListNode curr = head;

        while (curr != null) {
            result.Add(curr.val);
            curr = curr.next;
        }

        return result;
    }
}