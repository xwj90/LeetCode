public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var res = new List<int>();
        var q = new Queue<char>();
        var dict = new Dictionary<char, int>();
        var count = p.Length;
        foreach (var c in p)
            if (!dict.ContainsKey(c)) dict[c] = 1;
            else dict[c]++;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (count == 0 && q.Any())
            {
                var item = q.Dequeue();
                dict[item]++;
            }

            if (dict.ContainsKey(c) && dict[c] > 0)
            {
                dict[c]--;
                count--;
                if (count == 0) res.Add(i);
            }
            else
            {
                q.Clear();
                count = p.Length;
            }
        }
        return res;

    }
}
// @lc code=end

