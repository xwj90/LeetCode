public class Solution
{
    public string ReorganizeString(string S)
    {

        var max = S.GroupBy(p => p)
                    .Select(p => (val: p.Key, count: p.Count()))
                    .OrderBy(p => p.count).ToArray(); //order by frequency 

        if (max[max.Length - 1].count > (S.Length + 1) / 2) return string.Empty;

        var res = new char[S.Length];
        var t = 1;// fill odd position first
        foreach (var (c, count) in max)
        {
            for (var i = 0; i < count; i++)
            {
                if (t >= S.Length) t = 0;
                res[t] = c;
                t += 2;
            }
        }
        
        return new string(res);
    }
}
// @lc code=end

