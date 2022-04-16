public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var max = 0;
        var q = new Queue<char>();
        var hs = new HashSet<char>();
        foreach (var c in s)
        {
            q.Enqueue(c);
            if (!hs.Contains(c))
            {
                hs.Add(c);
            }
            else
            {
                while (q.Peek() != c)                
                    hs.Remove(q.Dequeue());
                
                q.Dequeue();
            }
            max = Math.Max(max, q.Count);
        }

        return max;
    }
}
// @lc code=end

