using System;
using System.Collections.Generic;
using System.Linq;
public partial class LRUCache
{
    class DoubleLinkedNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public DoubleLinkedNode Previous { get; set; }
        public DoubleLinkedNode Next { get; set; }
    }

    Dictionary<int, DoubleLinkedNode> LRUCache_dict;
    List<DoubleLinkedNode> LRUCache_items;
    DoubleLinkedNode first = null;
    DoubleLinkedNode last = null;
    int LRUCache_capacity;
    public LRUCache(int capacity)
    {
        LRUCache_items = new List<DoubleLinkedNode>(capacity);
        LRUCache_dict = new Dictionary<int, DoubleLinkedNode>(capacity);
        LRUCache_capacity = capacity;
    }

    public int Get(int key)
    {
        if (LRUCache_dict.ContainsKey(key))
        {
            var v = LRUCache_dict[key];
            UpdateUsage(v);
            return v.Value;
        }
        else
            return -1;
    }
    void UpdateUsage(DoubleLinkedNode v)
    {
        var next = v.Next;
        if (next != null)
        {
            if (v == first)
            {
                first = v.Next;
            }
            else
            {
                var pre = v.Previous;
                pre.Next = next;
                next.Previous = pre;
            }
            last.Next = v;
            v.Previous = last;
            last = v;
        }
    }

    public void Put(int key, int value)
    {
        if (LRUCache_dict.ContainsKey(key))
        {
            var v = LRUCache_dict[key];
           v.Value = value;
            UpdateUsage(v);
        }
        else
        {
            var v = new DoubleLinkedNode() { Key = key, Value = value };
            if (first == null)
            {
                first = v;
                last = v;
            }
            else
            {
                last.Next = v;
                v.Previous = last;
                last = v;
            }
            LRUCache_dict[key] = v;
            if (LRUCache_dict.Count > LRUCache_capacity)
            {
                var next = first.Next;
                LRUCache_dict.Remove(first.Key);
                first = next;
                first.Previous = null;
            }
        }
    }
}