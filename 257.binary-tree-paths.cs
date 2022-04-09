
public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<string>();
        var path = new List<int>();
        DFS(root, path, result);
        return result;
    }
    public void DFS(TreeNode root, List<int> path, List<string> results)
    {
        if (root == null)
            return;
        if (root.left == null & root.right == null)
        {
            path.Add(root.val);
            results.Add(string.Join("->", path));
            path.RemoveAt(path.Count - 1);
        }
        else
        {
            path.Add(root.val);
            DFS(root.left, path, results);
            DFS(root.right, path, results);
            path.RemoveAt(path.Count - 1);
        }
    }
}
// @lc code=end

