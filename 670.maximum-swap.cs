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


        var max = (new (int, int)[digs.Count]).ToList();
        for (var i = max.Count - 1; i >= 0; i--)
        {
            max[i] = (digs[i], i);
            if (i < max.Count - 1 && max[i].Item1 <= max[i + 1].Item1)
                max[i] = max[i + 1];
        }

        for (var i = 0; i < digs.Count - 1; i++)
            if (max[i + 1].Item1 > digs[i])
            {
                var j = max[i + 1].Item2;
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

