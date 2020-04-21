public class Solution
{
    private int[] weights;
    Random random = new Random();
    int max = 0;
    public Solution(int[] w)
    {
        this.weights = new int[w.Length];
        for (var i = 0; i < w.Length; i++)
        {
            max += w[i];
            weights[i] = max;
        }
    }

    public int PickIndex()
    {
        var id = random.Next(max);
        var idx = Array.BinarySearch(weights, id);
        if (idx >= 0) return idx + 1;
        else return ~idx;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */
// @lc code=end

