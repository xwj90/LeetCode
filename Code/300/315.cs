using System;
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{

    public IList<int> CountSmaller(int[] nums)
    {
        int[] r = new int[nums.Length];
        CountSmallerTreeNode root = null;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            root = CountSmaller_Insert(root, nums[i], 0, r, i);
        }
        return r;
    }
    CountSmallerTreeNode CountSmaller_Insert(CountSmallerTreeNode node, int val, int preSum, int[] r, int i)
    {
        if (node == null)
        {
            node = new CountSmallerTreeNode(val, 0, 1);
            r[i] = preSum;
        }
        else if (node.val == val)
        {
            node.dup++;
            r[i] = preSum + node.sum;
        }
        else if (node.val > val)
        {
            node.sum++;
            node.Left = CountSmaller_Insert(node.Left, val, preSum, r, i);
        }
        else
        {
            node.right = CountSmaller_Insert(node.right, val, preSum + node.sum + node.dup, r, i);
        }
        return node;
    }
    class CountSmallerTreeNode
    {
        public int val;
        public int sum;
        public int dup;
        public CountSmallerTreeNode Left;
        public CountSmallerTreeNode right;
        public CountSmallerTreeNode(int val, int sum, int dup)
        {
            this.val = val;
            this.sum = sum;
            this.dup = dup;
        }
    }
}