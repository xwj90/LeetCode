public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var charCount = new int[26];
        var maxCharCount = 0;
        var slow = 0;
        var res = int.MinValue;
        for (var i = 0; i < s.Length; i++)
        {
            if (++charCount[s[i] - 'A'] > maxCharCount)
            {
                maxCharCount = charCount[s[i] - 'A'];
            }
            while (i - slow + 1 -maxCharCount > k) //reduce
            {
                charCount[s[slow++] - 'A']--;
                maxCharCount = charCount.Max(p => p);
            }
            res = Math.Max(res, i - slow + 1);
        }
        return res;

    }
}
// @lc code=end

