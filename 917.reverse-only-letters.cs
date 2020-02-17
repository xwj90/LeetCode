public class Solution
{
    public string ReverseOnlyLetters(string S)
    {
        var chars=S.ToCharArray();
        var ids = new List<int>();
        for (var i = 0; i < S.Length; i++)
        {
            if (('a' <= S[i] && S[i] <= 'z') || 'A' <= S[i] && S[i] <= 'Z')
            {
                ids.Add(i);
            }
        }

        for (var i = 0; i < ids.Count / 2; i++)
        {
            var temp = chars[ids[i]];
            chars[ids[i]] = chars[ids[ids.Count - i - 1]];
            chars[ids[ids.Count - i - 1]] = temp;
        }
        return new string(chars);
    }
}
// @lc code=end

