/*
 * @lc app=leetcode id=395 lang=csharp
 *
 * [395] Longest Substring with At Least K Repeating Characters
 */

// @lc code=start
public class Solution
{
    public int LongestSubstring(string s, int k)
    {
        var res = 0;
        var q = new Queue<string>();
        q.Enqueue(s);

        while (q.Any())
        {
            var item = q.Dequeue();
            var counts = new int[26];
            foreach (var c in item) counts[c - 'a']++;

            var cs = new List<char>();
            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0 && counts[i] < k)
                {
                    cs.Add((char)('a' + i));
                }
            }
            if (cs.Any())
            {
                foreach (var newString in item.Split(cs.ToArray()))
                {
                    q.Enqueue(newString);
                }
            }
            else
            {
                res = Math.Max(res, item.Length);
            }
        }
        return res;
    }
}
// @lc code=end

