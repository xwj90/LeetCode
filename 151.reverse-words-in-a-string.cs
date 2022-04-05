public class Solution
{
    public string ReverseWords(string s)
    {
        s = s.Trim();
        var chars = new List<char>();
        for (var j = 0; j < s.Length; j++)
        {
            if (j > 0 && s[j] == ' ' && s[j - 1] == ' ')
                continue;
            chars.Add(s[j]);
        }

        chars.Reverse();

        var left = 0;
        for (var j = 0; j < chars.Count; j++)
        {
            if (chars[j] == ' ' || j == chars.Count - 1)
            {
                var right = j == chars.Count - 1 ? j : j - 1;
                Reverse(chars, left, right);
                left = j + 1;
            }
        }

        return new string(chars.ToArray());
    }
    public void Reverse(List<char> chars, int left, int right)
    {
        while (right > left)
        {
            var temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }
    }
}
// new Solution().ReverseWords("the sky is blue");

// @lc code=end

