/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet
{

    Dictionary<int, int> hashSet = new Dictionary<int, int>();
    List<int> id = new List<int>();
    Random r = new Random();
    /** Initialize your data structure here. */
    public RandomizedSet()
    {

    }

    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val)
    {
        if (hashSet.ContainsKey(val))
        {
            return false;
        }
        else
        {
            id.Add(val);
            hashSet[val] = id.Count - 1;
            return true;
        }
    }

    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val)
    {
        if (hashSet.ContainsKey(val))
        {
            var loc = hashSet[val];
            var last = id[id.Count - 1];
            id[loc] = last;
            hashSet[last] = loc;
            id.RemoveAt(id.Count - 1);
            hashSet.Remove(val);
            return true;
        }
        else
        {
            return false;
        }
    }

    /** Get a random element from the set. */
    public int GetRandom()
    {
        var i = r.Next(id.Count);
        return id[i];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

