public class Solution
{
    public int CountRangeSum(int[] nums, int lower, int upper)
    {
        var sums = new long[nums.Length + 1];
        for (var i = 0; i < nums.Length; ++i)
            sums[i + 1] = sums[i] + nums[i];
        return CountAndMergeSort(sums, 0, nums.Length + 1, lower, upper);
    }
    private int CountAndMergeSort(long[] sums, int start, int end, int lower, int upper)
    {
        if (end - start <= 1) return 0;
        var mid = (start + end) / 2;
        int count = CountAndMergeSort(sums, start, mid, lower, upper) + CountAndMergeSort(sums, mid, end, lower, upper);
        var j = mid;
        var k = mid;
        var t = mid;
        var cache = new long[end - start];
        for (int i = start, r = 0; i < mid; ++i, ++r)
        {
            while (k < end && sums[k] - sums[i] < lower) k++;
            while (j < end && sums[j] - sums[i] <= upper) j++;
            while (t < end && sums[t] < sums[i]) cache[r++] = sums[t++];
            cache[r] = sums[i];
            count += j - k;
        }
        Array.Copy(cache, 0, sums, start, t - start);
        return count;
    }
}
// @lc code=end

