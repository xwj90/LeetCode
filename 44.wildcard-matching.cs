public class Solution
{
    public bool IsMatch(string s, string p)
    {
        var i = 0;
        var j = 0;
        var i_M = -1;
        var j_M = -1;
        while (i < s.Length)
        {
            if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
            {
                i++;
                j++;
            }
            else if (j < p.Length && p[j] == '*')
            {
                i_M = i;
                j_M = j;
                j++;
            }
            else if (j_M != -1)
            {
                j = j_M + 1; //go back to prevoius *
                i = ++i_M; //go back to prevoius * and match i with one more element
            }
            else return false;
        }

        while (j < p.Length && p[j] == '*')
            j++;
        return j == p.Length;
    }

}
// @lc code=end

