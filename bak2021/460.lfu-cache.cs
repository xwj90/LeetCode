public class LFUCache
{
    long count = 0;
    SortedSet<DataNode> set = new SortedSet<DataNode>(Comparer<DataNode>.Create((d1, d2) => d1.order.CompareTo(d2.order)));
    private Dictionary<int, DataNode> dict = new Dictionary<int, DataNode>();
    private int capacity;
    public LFUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (dict.ContainsKey(key))
        {
            var node = dict[key];
            set.Remove(node);
            node.order = (node.order.frequency + 1, count++);
            set.Add(node);
            return node.value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (capacity > 0)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].value = value;
                Get(key);
            }
            else
            {
                if (dict.Count >= capacity)
                {
                    var min = set.Min;
                    dict.Remove(min.key);
                    set.Remove(min);
                }

                var node = new DataNode() { key = key, value = value, order = (0, count++) };
                dict[key] = node;
                set.Add(node);
            }
        }
    }

    public class DataNode
    {
        public int key;
        public int value;
        public (int frequency, long seq) order;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

