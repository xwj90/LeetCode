public class SummaryRanges
{

    /** Initialize your data structure here. */
    List<(int start, int end)> list = new List<(int start, int end)>();
    IComparer<(int start, int end)> compareStart = Comparer<(int start, int end)>.Create((x, y) => x.start > y.start ? 1 : x.start < y.start ? -1 : 0);
    IComparer<(int start, int end)> compareEnd = Comparer<(int start, int end)>.Create((x, y) => x.end > y.end ? 1 : x.end < y.end ? -1 : 0);
    IComparer<(int start, int end)> compareContains = Comparer<(int start, int end)>.Create((x, y) => x.start > y.end ? 1 : x.end < y.start ? -1 : 0);

    public SummaryRanges()
    {

    }

    public void AddNum(int val)
    {
        if (list.BinarySearch((val, val), compareContains) >= 0) return;

        var left = list.BinarySearch((-1, val - 1), compareEnd);
        var right = list.BinarySearch((val + 1, -1), compareStart);
        if (left >= 0 && right >= 0)
        {
            list[left] = (list[left].start, list[right].end);
            list.RemoveAt(right);
        }
        else if (left >= 0)
        {
            list[left] = (list[left].start, val);
        }
        else if (right >= 0)
        {
            list[right] = (val, list[right].end);
        }
        else
        {
            var bestposition = list.BinarySearch((-1, val), compareEnd);
            if (bestposition < 0)
            {
                list.Insert(~bestposition, (val, val));
            }

        }
    }

    public int[][] GetIntervals()
    {
        return this.list.Select(p => new int[] { p.start, p.end }).ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(val);
 * int[][] param_2 = obj.GetIntervals();
 */
// @lc code=end

