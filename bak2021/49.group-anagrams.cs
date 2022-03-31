/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var key = GetKey(str);
            if (dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict[key] = new List<string>() { str };
        }
        return dict.Values.ToList();
    }
    private string GetKey(string str)
    {
        var chars = str.OrderBy(p => p);
        return new string(chars.ToArray());
    }
}
// @lc code=end

