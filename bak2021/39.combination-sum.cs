public class Solution
{
    private Dictionary<(int, int), IList<IList<int>>> dict = new Dictionary<(int, int), IList<IList<int>>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var array = candidates.OrderBy(p => p).ToArray();
        var path = new List<int>();
        return Helper(path, array, target, 0);
    }
    private IList<IList<int>> Helper(IList<int> path, int[] array, int target, int start)
    {
        var result = new List<IList<int>>();
        var key = (target, start);
        if (dict.ContainsKey(key))
            return dict[key];
        for (var i = start; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                result.Add(new List<int>() { array[i] });
            }
            else if (array[i] < target)
            {
                var temp1 = path.ToList();
                temp1.Add(array[i]);
                var candidates = Helper(temp1, array, target - array[i], i);
                foreach (var list in candidates)
                {
                    var temp = new List<int>() { array[i] };
                    temp.AddRange(list);
                    result.Add(temp);
                }
            }
            else
            {
                break;
            }
        }
        dict[key] = result;
        return result;
    }
}
// @lc code=end

