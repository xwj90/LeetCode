public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;

        var arr = new List<List<char>>();
        for (var i = 0; i < numRows; i++)
        {
            arr.Add(new List<char>());
        }
        var down = 1;
        var level = -1;
        for (var i = 0; i < s.Length; i++)
        {
            if (down == 1)
                level++;
            else
                level--;
            arr[level].Add(s[i]);

            if (level == numRows - 1)
                down = 0;
            else if (level == 0)
                down = 1;
        }
        var results = new List<char>();
        for (var i = 0; i < numRows; i++)
        {
            results.AddRange(arr[i]);
        }
        return new string(results.ToArray());

    }
}
// @lc code=end

