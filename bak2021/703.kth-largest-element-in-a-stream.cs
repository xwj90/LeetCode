/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest
{
    int k;
    int c;
    SortedSet<(int value, int id)> ss = new SortedSet<(int value, int id)>();

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        foreach (var n in nums) this.Add(n);
    }

    public int Add(int val)
    {
        ss.Add((val, c++));
        if (ss.Count > k) ss.Remove(ss.Min);
        return ss.Min.value;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

