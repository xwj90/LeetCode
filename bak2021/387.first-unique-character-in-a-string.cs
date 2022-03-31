/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */
public class Solution
{
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!dict.ContainsKey(c))
            {
                dict[c] = 1;
            }
            else
            {
                dict[c] += 1;
            }
        }
        var hs = new HashSet<char>();
        foreach (var pair in dict)
        {
            if (pair.Value == 1)
            {
                hs.Add(pair.Key);
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (hs.Contains(s[i]))
            {
                return i;
            }
        }
        return -1;
    }
}

