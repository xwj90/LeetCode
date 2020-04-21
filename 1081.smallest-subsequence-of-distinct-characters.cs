public class Solution
{
    public string SmallestSubsequence(string text)
    {
        var stack = new Stack<int>();
        var last = new int[26];
        var seen = new int[26];
        for (var i = 0; i < text.Length; i++)
            last[text[i] - 'a'] = i;
        for (var i = 0; i < text.Length; i++)
        {
            int c = text[i] - 'a';
            if (seen[c]++ > 0) continue;
            while (stack.Any() && stack.Peek() > c && i < last[stack.Peek()])
                seen[stack.Pop()] = 0;
            stack.Push(c);
        }
        return string.Join("",stack.Reverse().Select(p=>(char)(p+'a')));
    }
}
// @lc code=end

