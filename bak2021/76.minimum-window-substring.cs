public class Solution
{
    public string MinWindow(string s, string t)
    {
        var map = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (!map.ContainsKey(t[i]))
                map[t[i]] = 0;
            map[t[i]]++;
        }
        int counter = t.Length;
        int begin = 0;
        var end = 0;
        var d = int.MaxValue;
        var head = 0;

        while (end < s.Length)
        {
            if (map.ContainsKey(s[end]))
            {
                if (map[s[end]]-- > 0) counter--;
                while (counter == 0)
                {
                    var newd = end - begin + 1;
                    if (newd < d)
                    {
                        d = newd;
                        head = begin;
                    }
                    if (map.ContainsKey(s[begin]))
                    {
                        if (map[s[begin]]++ == 0) counter++;
                    }
                    begin++;

                }
            }
            end++;
        }
        return d == int.MaxValue ? "" : s.Substring(head, d);
    }
}
// @lc code=end

