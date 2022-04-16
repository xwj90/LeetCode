public class Solution
{
    public IList<IList<string>> Partition(string s, int start = 0)
    {
        if (start == s.Length - 1)
            return new List<IList<string>>() { new List<string>() { s[start].ToString() } };

        var res = new List<IList<string>>();

        if (IsPalindorme(s.Substring(start, s.Length - start)) && start != s.Length)
        {
            res.Add(new List<string>() { s.Substring(start, s.Length - start) });
        }

        for (var i = start; i < s.Length; i++)
        {
            var temp = s.Substring(start, i - start + 1);
            if (IsPalindorme(temp))
            {
                foreach (var item in Partition(s, i + 1))
                {
                    item.Insert(0, temp);
                    res.Add(item);
                }
            }
        }
        return res;
    }
    public bool IsPalindorme(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (right > left)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
