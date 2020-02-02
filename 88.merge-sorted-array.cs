public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int left = m - 1;
        int right = n - 1;
        int end = m + n - 1;
        while (left >= 0 && right >= 0)
        {
            if (nums1[left] > nums2[right])
            {
                nums1[end--] = nums1[left--];
            }
            else
            {
                nums1[end--] = nums2[right--];
            }
        }
        while (right >= 0) nums1[end--] = nums2[right--];
    }
}
// @lc code=end

