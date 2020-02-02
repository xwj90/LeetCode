/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
public class LRUCache
{

    Dictionary<int, int> dict = new Dictionary<int, int>();
    List<int> q = new List<int>();
    int maxCapacity = 0;
    public LRUCache(int capacity)
    {
        this.maxCapacity = capacity;
    }

    public int Get(int key)
    {
        if (dict.ContainsKey(key))
        {
            RefreshKey(key);
            return dict[key];
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        dict[key] = dict[value];
        RefreshKey(key);
    }
    public void RefreshKey(string key)
    {

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

