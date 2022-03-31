public class MyLinkedList
{
    public class LinkedNode
    {
        public int val = -1;
        public LinkedNode previous;
        public LinkedNode next;
    }
    private LinkedNode dummpyHead;
    private LinkedNode dummpyTail;

    public MyLinkedList()
    {
        dummpyHead = new LinkedNode();
        dummpyTail = new LinkedNode();
        dummpyHead.next = dummpyTail;
        dummpyTail.previous = dummpyHead;
    }

    public int Get(int index)
    {
        var current = dummpyHead;
        for (var i = 0; i <= index; i++)
        {
            current = current.next;
            if (current == null) return -1;
        }
        return current.val;
    }

    public void AddAtHead(int val)
    {
        var node = new LinkedNode() { val = val };
        node.next = dummpyHead.next;
        node.previous = dummpyHead;
        dummpyHead.next.previous = node;
        dummpyHead.next = node;
    }

    public void AddAtTail(int val)
    {
        var node = new LinkedNode() { val = val };
        node.next = dummpyTail;
        node.previous = dummpyTail.previous;
        dummpyTail.previous.next = node;
        dummpyTail.previous = node;
    }

    public void AddAtIndex(int index, int val)
    {
        var current = dummpyHead;
        for (var i = 0; i <= index; i++)
        {
            current = current.next;
            if (current == dummpyTail && i == index)
            {
                AddAtTail(val);
                return;
            }
            else if (current == null)
            {
                return;
            }
        }
        var node = new LinkedNode() { val = val };

        node.next = current;
        node.previous = current.previous;
        current.previous.next = node;
        current.previous = node;
    }

    public void DeleteAtIndex(int index)
    {
        var current = dummpyHead;
        for (var i = 0; i <= index; i++)
        {
            current = current.next;
            if (current == null) return;
        }
        if (current != dummpyHead && current != dummpyTail)
        {
            current.previous.next = current.next;
            current.next.previous = current.previous;
        }
    }
}