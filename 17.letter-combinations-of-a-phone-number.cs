public class Solution
{
    char[][] phone = new char[][]{
                            new char[]{'a','b','c'},
                            new char[]{'d','e','f'},
                            new char[]{'g','h','i'},
                            new char[]{'j','k','l'},
                            new char[]{'m','n','o'},
                            new char[]{'p','q','r','s'},
                            new char[]{'t','u','v'},
                            new char[]{'w','x','y','z'}
                            };
    public IList<string> LetterCombinations(string digits, int start = 0)
    {
        var results = new List<string>();
        if (string.IsNullOrEmpty(digits))
            return results;

        var idx = (int)(digits[start] - '2');

        if (start == digits.Length - 1)
            foreach (var c in phone[idx])
                results.Add(c.ToString());
        else
            foreach (var item in LetterCombinations(digits, start + 1))
                foreach (var c in phone[idx])
                    results.Add(c + item);

        return results;
    }
}
// @lc code=end

