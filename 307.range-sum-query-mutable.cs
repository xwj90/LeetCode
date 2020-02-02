public class NumArray
{
    SegmentTreeNode root = null;

    public NumArray(int[] nums)
    {
        root = buildTree(nums, 0, nums.Length - 1);
    }

    public void Update(int i, int val)
    {
        Update(root, i, val);
    }

    private void Update(SegmentTreeNode root, int pos, int val)
    {
        if (root != null)
        {
            if (root.start == root.end)
            {
                root.sum = val;
            }
            else
            {
                var mid = root.start + (root.end - root.start) / 2;
                if (pos <= mid) Update(root.left, pos, val);
                else Update(root.right, pos, val);
                root.sum = (root.left == null ? 0 : root.left.sum)
                + (root.right == null ? 0 : root.right.sum);
            }
        }
    }

    public int SumRange(int i, int j)
    {
        return SumRange(root, i, j);
    }
    private int SumRange(SegmentTreeNode root, int start, int end)
    {
        if (root == null) return 0;
        if (root.end == end && root.start == start) return root.sum;
        var mid = root.start + (root.end - root.start) / 2;
        if (end <= mid) return SumRange(root.left, start, end);
        else if (start >= mid + 1) return SumRange(root.right, start, end);
        else return SumRange(root.left, start, mid) + SumRange(root.right, mid + 1, end);
    }

    private SegmentTreeNode buildTree(int[] nums, int start, int end)
    {
        if (start > end) return null;
        var ret = new SegmentTreeNode() { start = start, end = end };
        if (start == end)
        {
            ret.sum = nums[start];
        }
        else
        {
            int mid = start + (end - start) / 2;
            ret.left = buildTree(nums, start, mid);
            ret.right = buildTree(nums, mid + 1, end);
            ret.sum = ret.left.sum + ret.right.sum;
        }
        return ret;
    }
}

public class SegmentTreeNode
{
    public int start;
    public int end;
    public SegmentTreeNode left;
    public SegmentTreeNode right;
    public int sum;
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */
// @lc code=end

