public class Solution
{
    public bool IsNStraightHand(int[] hand, int W)
    {
        if (hand.Length % W != 0) return false;
        var group = hand.GroupBy(p => p).OrderBy(p => p.Key).Select(p => (Key: p.Key, Count: p.Count())).ToList();

        while (group.Any())
        {
            var first = group.First();
            for (int i = 0; i < W; ++i)
            {
                if (i >= group.Count) return false;
                if (group[i].Key != first.Key + i) return false;
                group[i] = (group[i].Key, group[i].Count - 1);
            }
            for (int i = W - 1; i >= 0; i--)
            {
                if (group[i].Count == 0)
                    group.RemoveAt(i);
            }
        }
        return true;
    }
}
// @lc code=end

