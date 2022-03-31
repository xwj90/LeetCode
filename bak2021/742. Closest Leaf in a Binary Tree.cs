public class Solution
{
    Dictionary<int, (int distance, int val)> dict = new Dictionary<int, (int distance, int val)>();
    public int FindClosestLeaf(TreeNode root, int k)
    {
        FindClosestLeaf(root);
        UpdateClosestLeaf(root);
        return dict[k].val;
    }
    public (int distance, int val) FindClosestLeaf(TreeNode node)
    {
        if (node == null)
            return (int.MaxValue, int.MaxValue);
        (int distance, int val) res;
        if (node.left == null && node.right == null)
        {
            res = (0, node.val);
        }
        else
        {
            var left = FindClosestLeaf(node.left);
            var right = FindClosestLeaf(node.right);

            if (left.distance < right.distance)
                res = (left.distance + 1, left.val);
            else
                res = (right.distance + 1, right.val);
        }
        dict[node.val] = res;
        return res;
    }
    public void UpdateClosestLeaf(TreeNode node)
    {
        if (node == null) return;
        var parent = dict[node.val];
        if (node.left != null && dict[node.left.val].distance > parent.distance + 1)
            dict[node.left.val] = (parent.distance + 1, parent.val);
        if (node.right != null && dict[node.right.val].distance > parent.distance + 1)
            dict[node.right.val] = (parent.distance + 1, parent.val);
        UpdateClosestLeaf(node.left);
        UpdateClosestLeaf(node.right);
    }
}