public class Solution
{
    public string GetPermutation(int n, int k)
    {
        var candidates = new List<int>();
        for (var i = 1; i <= n; i++)
            candidates.Add(i);

        var current = 1;
        var group = new int[n + 1];
        group[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            current *= i;
            group[i] = current;
        }

        var sb = new StringBuilder();
        k--;
        for (var i = 1; i <= n; i++)
        {
            var ind = k / group[n - i];
            sb.Append(candidates[ind].ToString());
            candidates.RemoveAt(ind);
            k -= ind * group[n - i];
        }

        return sb.ToString();
    }
}
// @lc code=end

