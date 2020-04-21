public class Solution
{
    public string[] ReorderLogFiles(string[] logs)
    {
        return logs.Where(x => !char.IsDigit(x[x.IndexOf(' ') + 1]))
            .OrderBy(y => y.Split(' ', 2)[1])
            .ThenBy(z => z.Split(' ', 2)[0])
            .Union(logs.Where(x => char.IsDigit(x[x.IndexOf(' ') + 1])))
            .ToArray();
    }
}