/*
 * @lc app=leetcode id=519 lang=csharp
 *
 * [519] Random Flip Matrix
 */

// @lc code=start
public class Solution
{
    Random random = new Random();
    Dictionary<int, int> v = new Dictionary<int, int>();
    int rem;
    int n_rows;
    int n_cols;
    public Solution(int n_rows, int n_cols)
    {
        this.n_rows = n_rows;
        this.n_cols = n_cols;
        this.rem = n_rows * n_cols;
    }

    public int[] Flip()
    {
        var r = random.Next(rem--);
        var x = r;
        if (v.ContainsKey(r)) x = v[r];

        if (v.ContainsKey(rem)) v[r] = v[rem];
        else v[r] = rem;
        return new int[] { x / n_cols, x % n_cols };
    }

    public void Reset()
    {
        v.Clear();
        rem = n_rows * n_cols;
    }


}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(n_rows, n_cols);
 * int[] param_1 = obj.Flip();
 * obj.Reset();
 */
// @lc code=end

