public class Solution
{
    public string AddBinary(string a, string b)
    {
        var ind = 0;
        var rest = 0;
        var chars = new List<int>();
        while (ind < a.Length || ind < b.Length)
        {
            var left = (ind < a.Length) ? a[a.Length - ind - 1] - '0' : 0;
            var right = (ind < b.Length) ? b[b.Length - ind - 1] - '0' : 0;
            var current = left + right + rest;
            chars.Add(current % 2);
            rest = current / 2;
            ind++;
        }

        if (rest > 0) chars.Add(rest);
        chars.Reverse();
        return string.Join("", chars);

    }
}
// @lc code=end

