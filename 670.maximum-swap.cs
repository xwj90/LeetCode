public class Solution
{
    public int MaximumSwap(int num)
    {
        var digs = new List<int>();
        while (num > 0)
        {
            digs.Add(num % 10);
            num = num / 10;
        }
        digs.Reverse();


        var max = new (int value, int idx)[digs.Count];
        for (var i = max.Length - 1; i >= 0; i--)
        {
            max[i] = (digs[i], i);
            if (i < max.Length - 1 && max[i].value <= max[i + 1].value)
                max[i] = max[i + 1];
        }

        for (var i = 0; i < digs.Count - 1; i++)
            if (max[i + 1].value > digs[i])
            {
                var j = max[i + 1].idx;
                var temp = digs[i];
                digs[i] = digs[j];
                digs[j] = temp;
                break;
            }

        var r = 0;
        foreach (var d in digs) r = r * 10 + d;
        return r;

    }
}
// @lc code=end

