public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (postorder.Length == 0) return null;
        var node = new TreeNode(postorder[postorder.Length - 1]);
        if (postorder.Length == 1) return node;
        var split = Array.IndexOf(inorder, node.val);

        node.left = BuildTree(inorder.Take(split).ToArray(), postorder.Take(split).ToArray());
        node.right = BuildTree(inorder.Skip(split + 1).ToArray(), postorder.Skip(split).Take(postorder.Length - split - 1).ToArray());
        return node;
    }
}