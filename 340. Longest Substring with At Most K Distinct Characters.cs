public class Solution
{
    public int LengthOfLongestSubstringKDistinct(string s, int k)
    {
        var array = new int[256];
        var slow = 0;
        var res = 0;
        for (var i = 0; i < s.Length; i++)
        {
            int v = s[i];
            array[v]++;
            while (array.Count(p => p > 0) > k && slow <= i)
            {
                Console.WriteLine($"remove {slow} at {i}");
                array[s[slow++]]--;

            }
            res = Math.Max(res, array.Sum());
        }
        return res;
    }
}