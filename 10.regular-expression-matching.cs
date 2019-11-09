public class Solution
{
    Dictionary<(string, string), bool> dict = new Dictionary<(string, string), bool>();
    public bool IsMatch(string s, string p)
    {
        if (s.Length == 0 && p.Length == 0)
            return true;
        var result = false;
        if (p.Length > 1 && p[1] == '*')
            result = IsMatch(s, p.Substring(2));
        if (!result)
        {
            if ((s.Length > 0 && p.Length == 0) || (s.Length == 0 && p.Length > 0))
                return false;

            if (dict.ContainsKey((s, p)))
            {
                return dict[(s, p)];
            }
            else if (p[0] == s[0])
            {
                if (p.Length > 1 && p[1] == '*')
                {
                    var match = IsMatch(s, p.Substring(2));
                    if (match) result = true;
                    else
                    {
                        var index = 0;
                        while (index < s.Length && s[index] == p[0])
                        {
                            if (IsMatch(s.Substring(index + 1), p.Substring(2)))
                            {
                                result = true;
                            }
                            index++;
                        }
                    }
                }
                else
                {
                    result = IsMatch(s.Substring(1), p.Substring(1));
                }
            }
            else if (p[0] == '.')
            {
                if (p.Length > 1 && p[1] == '*')
                {
                    var match = IsMatch(s, p.Substring(2));
                    if (match) result = true;
                    else
                    {
                        var index = 0;
                        while (index < s.Length)
                        {
                            if (IsMatch(s.Substring(index + 1), p.Substring(2)))
                            {
                                result = true;
                            }
                            index++;
                        }
                    }
                }
                else
                {
                    result = IsMatch(s.Substring(1), p.Substring(1));
                }
            }
        }
        dict[(s, p)] = result;
        return result;
    }
}
// @lc code=end

