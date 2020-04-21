public class Solution
{
    public IList<int> CountSmaller(int[] nums)
    {
        var res = new int[nums.Length];
        var list = new List<(int val, int idx, int count)>();
        for (var i = 0; i < nums.Length; i++)
        {
            list.Add((nums[i], i, 0));
        }

        foreach (var (val, idx, count) in MergeSort(list, 0, list.Count - 1))
        {
            res[idx] = count;
        }

        return res.ToList();
    }

    public List<(int val, int idx, int count)> MergeSort(List<(int val, int idx, int count)> nums, int start, int end)
    {
        if (start > end) return new List<(int val, int idx, int count)>();
        else if (start == end) return new List<(int val, int idx, int count)>() { nums[start] };
        var mid = (end + start) / 2;
        var res = new List<(int, int, int)>();
        var left = MergeSort(nums, start, mid);
        var right = MergeSort(nums, mid + 1, end);
        var i = 0;
        var j = 0;
        while (i < left.Count || j < right.Count)
        {
            var v1 = i < left.Count ? left[i].val : int.MaxValue;
            var v2 = j < right.Count ? right[j].val : int.MaxValue;
            if (v2 < v1)
            {
                res.Add(right[j++]);
            }
            else
            {
                res.Add((left[i].val, left[i].idx, left[i++].count + j));
            }
        }
        return res;
    }
}