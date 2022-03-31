public class Solution
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var hs = new HashSet<string>();
        foreach (var w in banned)
            hs.Add(w.ToLower());
        paragraph = new System.Text.RegularExpressions.Regex("\\W+").Replace(paragraph.ToLower(), " ");
        var g = paragraph.Split(' ')
            .Where(p => !hs.Contains(p))
            .GroupBy(p => p)
            .Select(p => (key: p.Key, count: p.Count())).ToList();
        var max = g.Max(p => p.count);
        return g.First(p => p.count == max).key;
    }
}
// @lc code=end

