public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        var max = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            max[s[i] - 'a'] = i;
        }

        var right = 0;
        var res = new List<int>();
        var count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            right = Math.Max(right, max[s[i] - 'a']);
            if (i == right)
            {
                res.Add(i + 1 - count);
                count = i + 1;
            }
        }

        return res;
    }
}

