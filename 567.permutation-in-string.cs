public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        var charCount = new int[26];
        foreach (var c in s1)
            charCount[c - 'a']++;

        var slow = 0;
        for (var i = 0; i < s2.Length; i++)
        {
            if (--charCount[s2[i] - 'a'] == 0)
            {
                if (charCount.All(p => p == 0)) return true;
            }
            else
            {
                while (charCount.Any(p => p < 0))
                {
                    charCount[s2[slow++] - 'a']++;
                }
            }
        }

        return false;

    }
}
// @lc code=end

