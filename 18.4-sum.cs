public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var hs = new HashSet<(int, int, int, int)>();
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                var left = j + 1;
                var right = nums.Length - 1;

                while (right > left)
                {
                    var sum = nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum > target)
                        right--;
                    else if (sum < target)
                        left++;
                    else
                    {
                        hs.Add((nums[i], nums[j], nums[left], nums[right]));
                        left++;
                        right--;
                    }
                }
            }
        }

        return hs.Select(p => (IList<int>)new List<int> { p.Item1, p.Item2, p.Item3, p.Item4 }).ToList();
    }
}

