public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<string>();
        var path = new Stack<int>();
        DFS(root, path, result);
        return result;
    }
    public void DFS(TreeNode node, Stack<int> paths, List<string> result)
    {
        if (node != null)
        {
            paths.Push(node.val);
            if (node.left != null) DFS(node.left, paths, result);
            if (node.right != null) DFS(node.right, paths, result);
            if (node.left == null & node.right == null) result.Add(string.Join("->", paths.Reverse()));
            paths.Pop();
        }
    }
}
// @lc code=end

