
public class Solution
{
    public IList<string> RestoreIpAddresses(string s, int start = 0, int n = 4)
    {
        var results = new List<string>();

        for (var i = start; i < s.Length; i++)
        {
            var temp = s.Substring(start, i - start + 1);
            if (Convert.ToInt32(temp) > 255 || (temp[0] == '0' && temp.Length > 1))
            {
                break;
            }

            if (n == 1 && i == s.Length - 1)
            {
                results.Add(temp);
            }
            else
            {
                foreach (var item in RestoreIpAddresses(s, i + 1, n - 1))
                {
                    results.Add(temp + "." + item);
                }
            }
        }

        return results;
    }
}
// @lc code=end

