public class Solution
{
    public IList<string> AddOperators(string num, int target)
    {
        var res = new List<string>();
        if (num == null || num.Length == 0) return res;
        DFS(res, "", num, target, 0, 0, 0);
        return res;
    }
    private void DFS(List<string> s, string path, string num, int target, int pos, long eval, long multed)
    {
        if (pos == num.Length)
        {
            if (target == eval)
                s.Add(path);
            return;
        }
        for (int i = pos; i < num.Length; i++)
        {
            if (i != pos && num[pos] == '0') break; //don't want to see pattern 0x
            long cur = Convert.ToInt64(num.Substring(pos, i + 1 - pos));
            if (pos == 0)
            {
                DFS(s, path + cur, num, target, i + 1, cur, cur);
            }
            else
            {
                DFS(s, path + "+" + cur, num, target, i + 1, eval + cur, cur);
                DFS(s, path + "-" + cur, num, target, i + 1, eval - cur, -cur);
                DFS(s, path + "*" + cur, num, target, i + 1, eval - multed + multed * cur, multed * cur);
            }
        }
    }
}