using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    Dictionary<Tuple<string, string>, int> MinDistance_dict = new Dictionary<Tuple<string, string>, int>();
    public int MinDistance(string word1, string word2)
    {
        if (word1.Length == 0)
            return word2.Length;
        else if (word2.Length == 0)
            return word1.Length;
        var t = new Tuple<string, string>(word1, word2);
        if (MinDistance_dict.ContainsKey(t))
            return MinDistance_dict[t];
        var d = -1;
        if (word1[0] == word2[0])
            d = MinDistance(word1.Substring(1, word1.Length - 1), word2.Substring(1, word2.Length - 1));
        else
        {
            var replace = 1 + MinDistance(word1.Substring(1, word1.Length - 1), word2.Substring(1, word2.Length - 1));
            var add1 = 1 + MinDistance(word1, word2.Substring(1, word2.Length - 1));
            var add2 = 1 + MinDistance(word1.Substring(1, word1.Length - 1), word2);
            d = Math.Min(Math.Min(replace, add1), add2);
        }
        MinDistance_dict[t] = d;
        return d;
    }

}
