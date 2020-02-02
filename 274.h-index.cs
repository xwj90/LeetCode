public class Solution
{
    public int HIndex(int[] citations)
    {
        var a = new int[citations.Length + 1];
        foreach (var n in citations)
            if (n > citations.Length) a[citations.Length]++;
            else a[n]++;

        int count = 0;
        for (var i = citations.Length; i >= 0; i--)
        {
            count += a[i];
            if (count >= i) return i;
        }
        return 0;

        // var a = citations.OrderByDescending(p => p).ToArray();
        // for (var i = 0; i < a.Length; i++)
        // {
        //     if ((i + 1) == a[i]) return a[i];
        // }
        // return 0;
    }
}
// @lc code=end

