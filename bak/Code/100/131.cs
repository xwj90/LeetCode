using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        var result = new List<IList<string>>();
        PartitionDFS(result, new List<string>(), s, 0);
        return result;
    }
    private void PartitionDFS(IList<IList<string>> result, List<string> list, string s, int pos)
    {
        if (pos == s.Length) result.Add(new List<string>(list));
        for (int i = pos; i < s.Length; i++)
            if (Partition_IsPalindrome(s.Substring(pos, i + 1 - pos)))
            {
                list.Add(s.Substring(pos, i + 1 - pos));
                PartitionDFS(result, list, s, i + 1);
                list.RemoveAt(list.Count - 1);
            }
    }
    private bool Partition_IsPalindrome(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[s.Length - 1 - i])
                return false;
        return true;
    }
}