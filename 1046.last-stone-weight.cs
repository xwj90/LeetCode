public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var fakeIndex = 0;
        var sl = new SortedSet<(int Weight, int Id)>();
        foreach (var w in stones)
            sl.Add((w, fakeIndex++));

        while (sl.Count > 1)
        {
            var m1 = sl.Max;
            sl.Remove(m1);
            var m2 = sl.Max;
            sl.Remove(m2);
            if (m1.Weight != m2.Weight) sl.Add((m1.Weight - m2.Weight, fakeIndex++));
        }
        return sl.FirstOrDefault().Weight;

    }
}
// @lc code=end

