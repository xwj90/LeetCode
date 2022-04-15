
public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }
    public TreeNode SortedArrayToBST(int[] nums, int left, int right)
    {
        if (left == right)
            return new TreeNode(nums[left]);
        else if (left < right)
        {
            var mid = left + (right - left) / 2;
            var root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBST(nums, left, mid - 1);
            root.right = SortedArrayToBST(nums, mid + 1, right);
            return root;
        }
        else
            return null;
    }
}
// @lc code=end

