/*
 * @lc app=leetcode id=381 lang=csharp
 *
 * [381] Insert Delete GetRandom O(1) - Duplicates allowed
 */
public class RandomizedCollection
{

    private List<int> data = new List<int>();
    private Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
    private Random random = new Random();

    /** Initialize your data structure here. */
    public RandomizedCollection()
    {

    }

    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert(int val)
    {
        if (!map.ContainsKey(val))
        {
            map[val] = new HashSet<int>();
        }
        map[val].Add(data.Count);
        data.Add(val);
        return map[val].Count == 1;

    }

    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove(int val)
    {
        if (!map.ContainsKey(val) || map[val].Count == 0)
        {
            return false;
        }
        else
        {
            var remove_idx = map[val].First();
            map[val].Remove(remove_idx);

            var last = data.Last();
            data[remove_idx] = last;

            map[last].Add(remove_idx);
            map[last].Remove(data.Count - 1);

            data.RemoveAt(data.Count - 1);

            return true;
        }
    }

    /** Get a random element from the collection. */
    public int GetRandom()
    {
        return data[random.Next(data.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */

