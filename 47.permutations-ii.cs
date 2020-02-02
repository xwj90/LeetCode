/*
 * @lc app=leetcode id=47 lang=csharp
 *
 * [47] Permutations II
 */

// @lc code=start
public class Solution
{

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        var candidates = nums.ToList();
        return Helper(candidates);
    }
    IList<IList<int>> Helper(List<int> list)
    {

        var result = new List<IList<int>>();

        if (list.Count == 1)
        {
            result.Add(list);
            return result;
        }

        var hs = new HashSet<int>();
        var count = list.Count;
        for (var i = 0; i < count; i++)
        {
            var current = list[i];
            if (hs.Contains(current))
                continue;
            hs.Add(current);
            list.RemoveAt(i);
            var children = Helper(list);
            foreach (var child in children)
            {
                var newItem = new List<int>();
                newItem.Add(current);
                newItem.AddRange(child);
                result.Add(newItem);
            }
            list.Insert(i, current);
        }
        return result;
    }
}
// @lc code=end

