public class Solution
{
    public int Candy(int[] ratings)
    {
        var res = new int[ratings.Length];
        var nums = new (int val, int idx)[ratings.Length];
        for (var i = 0; i < ratings.Length; i++)
        {
            nums[i] = (ratings[i], i);
        }

        Array.Sort(nums); //tuple is sorting by first element then second element ...
        for (var i = 0; i < nums.Length; i++)
        {
            var (val, idx) = nums[i];
            var left = 0;
            if (idx > 0 && val > ratings[idx - 1])
                left = res[idx - 1];
            var right = 0;
            if (idx < ratings.Length - 1 && val > ratings[idx + 1])
                right = res[idx + 1];
            res[idx] = Math.Max(left, right) + 1;
        }
        return res.Sum();
    }
}

//[1,3,4,5,2]
