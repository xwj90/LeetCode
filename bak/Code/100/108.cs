
using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }
    private TreeNode SortedArrayToBST(int[] nums, int left, int right)
    {
        if (left > right)
            return null;
        var mid = (left + right) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBST(nums, left, mid - 1);
        root.right = SortedArrayToBST(nums, mid + 1, right);
        return root;
    }

}