public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var i = num1.Length - 1;
        var j = num2.Length - 1;
        var prev = 0;
        var res = new List<int>();
        while (i >= 0 || j >= 0)
        {
            var current = (int)((i >= 0 ? num1[i] : '0') - '0') +(int)((j >= 0 ? num2[j] : '0') - '0') + prev;
            prev = current / 10;
            res.Add(current % 10);
            i--;
            j--;
        }
        if (prev > 0) res.Add(prev);
        res.Reverse();
        if (!res.Any()) res.Add(0);
        return string.Join("", res);
    }
}
// @lc code=end

