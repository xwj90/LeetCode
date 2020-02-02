public class Solution
{
    private Dictionary<int, int> dict = new Dictionary<int, int>();
    public string Multiply(string num1, string num2)
    {
        for (var i = 0; i < num1.Length; i++)
            for (var j = 0; j < num2.Length; j++)
                AddValue(i + j, Convert.ToInt32(num1[num1.Length - i - 1] - '0') * Convert.ToInt32(num2[num2.Length - j - 1] - '0'));

        var maxBit = dict.Keys.Max();
        for (var i = 0; i <= maxBit; i++)
            if (dict.ContainsKey(i))
            {
                var num = dict[i] / 10;
                var count = 1;
                while (num > 0)
                {
                    AddValue(i + count, num % 10);
                    count++;
                    num = num / 10;
                }
                dict[i] = dict[i] % 10;
            }

        maxBit = dict.Keys.Max();
        var sb = new StringBuilder();
        for (var i = maxBit; i >= 0; i--)
        {
            if (dict.ContainsKey(i))
                sb.Append(dict[i].ToString());
            else
                sb.Append("0");
        }
        var s = sb.ToString().TrimStart('0');
        if (s == string.Empty)
            return "0";
        else
            return s;
    }

    private void AddValue(int i, int v)
    {
        if (!dict.ContainsKey(i))
            dict[i] = v;
        else
            dict[i] += v;
    }
}
// @lc code=end

