using System;

public class Solution
{
    Dictionary<string, bool> dict = new Dictionary<string, bool>();
    public bool IsMatch(string s, string p)
    {
        List<string> patterns = new List<string>();
        for (int i = 0; i < p.Length; i++)
        {
            if ((i + 1) < p.Length && s[i + 1] == '*')
            {
                patterns.Add(s[i] + "" + s[i + 1]);
                i++;
            }
            else
                patterns.Add(s[i] + "");
        }

        return IsMatch(s, 0, patterns.ToArray(), 0);

    }
    bool IsMatch(string s, int start, string[] patterns, int p)
    {
        if (start == s.Length && p == patterns.Length)
            return true;
        else if (start < s.Length && p == patterns.Length)
            return false;

        var key = s + "_" + start + "_" + p;
        var c = patterns[p];
        var status = false;
        if (dict.ContainsKey(key))
            status = dict[key];
        if (c.Length == 1)
        {
            if (start == s.Length)
                status = false;
            else
                status = (s[start] == c[0] || c[0] == '.') && IsMatch(s, start + 1, patterns, p + 1);
        }
        else
        {
            status = IsMatch(s, start, patterns, p + 1) ||
             ((s[start] == c[0] || c[0] == '.') && IsMatch(s, start + 1, patterns, p));
        }
        dict[key] = status;
        return status;
    }
}
