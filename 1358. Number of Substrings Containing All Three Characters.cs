public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        var flag = new int[3];
        var slow = 0;
        var res = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'b' || s[i] == 'c')
            {
                flag[s[i] - 'a']++;
            }

            while ((s[slow] != 'a' && s[slow] != 'b' && s[slow] != 'c') || flag[slow] > 1)
            {
                slow++;
            }

            if (flag.All(p => p > 0))
            {
                res += slow + 1;
            }
        }
        return res;
    }
}