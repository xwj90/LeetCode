public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
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

        var count = list.Count;
        for (var i = 0; i < count; i++)
        {
            var current = list[i];
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

