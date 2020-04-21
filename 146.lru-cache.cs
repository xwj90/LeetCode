public class LRUCache
{
    private class LinkedNode
    {
        public int Key;
        public int Value;
        public LinkedNode Prev;
        public LinkedNode Next;
    }
    Dictionary<int, LinkedNode> dict = new Dictionary<int, LinkedNode>();
    int maxCapacity = 0;
    private LinkedNode head;
    private LinkedNode end;

    public LRUCache(int capacity)
    {
        this.maxCapacity = capacity;
    }

    public int Get(int key)
    {
        if (dict.ContainsKey(key))
        {
            var node = this.dict[key];
            Refresh(node);
            return node.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        LinkedNode node = new LinkedNode() { Key = key, Value = value };
        if (!dict.ContainsKey(key))
            dict[key] = node;
        else
            node = dict[key];
        node.Value = value;
        
        Refresh(node);
        if (dict.Count > this.maxCapacity)
        {
            Console.WriteLine($" remove {head.Key}");
            dict.Remove(head.Key);
            head = head.Next;
            if (head != null) head.Prev = null;
        }
    }

    private void Refresh(LinkedNode node)
    {
        if (head == null)
        {
            head = node;
            end = node;
        }
        else if (end != node)
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;
            if (node.Next != null)
                node.Next.Prev = node.Prev;
            if (head == node)
                head = head.Next;
            end.Next = node;
            node.Prev = end;
            node.Next = null;
            end = node;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

