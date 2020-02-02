public class Solution
{
    public int MaxProduct(string[] words)
    {
        words = Convert(words);
        var res = 0;
        var bitMasks = new int[words.Length];
        for (var i = 0; i < words.Length; i++)
            bitMasks[i] = GetBitMask(words[i]);
        for (var i = 0; i < words.Length; i++)
            for (var j = i + 1; j < words.Length; j++)
                if ((bitMasks[i] & bitMasks[j]) == 0)
                    res = Math.Max(res, words[i].Length * words[j].Length);

        return res;
    }
    public int GetBitMask(string s)
    {
        var res = 0;
        foreach (var c in s)
            res |= 1 << ((int)c - (int)'a');
        return res;
    }
    public string[] Convert(string[] words)
    {
        var dict = new Dictionary<int, string>();
        foreach (var w in words)
        {
            var bitmask = GetBitMask(w);
            if (!dict.ContainsKey(bitmask)) dict[bitmask] = w;
            else if (w.Length > dict[bitmask].Length) dict[bitmask] = w;
        }
        return dict.Values.ToArray();
    }
}
// @lc code=end

