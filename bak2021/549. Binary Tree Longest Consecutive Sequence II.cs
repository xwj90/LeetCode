public class Solution
{
    int maxval = 0;
    public int LongestConsecutive(TreeNode root)
    {
        LongestPath(root);
        return maxval;
    }

    public (int increse, int decrese) LongestPath(TreeNode root)
    {
        if (root == null) return (0, 0);
        var increse = 1;
        var decrese = 1;
        if (root.left != null)
        {
            var l = LongestPath(root.left);
            if (root.val == root.left.val + 1)
                decrese = l.decrese + 1;
            else if (root.val == root.left.val - 1)
                increse = l.increse + 1;
        }
        if (root.right != null)
        {
            var r = LongestPath(root.right);
            if (root.val == root.right.val + 1)
                decrese = Math.Max(decrese, r.decrese + 1);
            if (root.val == root.right.val - 1)
                increse = Math.Max(increse, r.increse + 1);
        }
        maxval = Math.Max(maxval, decrese + increse - 1);
        return (increse, decrese);
    }
}