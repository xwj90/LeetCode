public class Solution
{
    public int[] FindMode(TreeNode root)
    {
        Stack<TreeNode> stack = new();
        TreeNode prev = null;
        List<int> results = new();
        int maxOccurance = 0;
        int currentOccurance = 0;

        while (root != null || stack.Any())
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                var node = stack.Pop();

                //process node
                if (prev != null)
                {
                    if (prev.val == node.val)
                        currentOccurance++;
                    else
                        currentOccurance = 1;

                    if (currentOccurance > maxOccurance)
                        results.Clear();
                    if (currentOccurance >= maxOccurance)
                        results.Add(node.val);
                    maxOccurance = Math.Max(maxOccurance, currentOccurance);
                }
                else
                {
                    maxOccurance = 1;
                    currentOccurance = 1;
                    results.Add(node.val);
                }
                prev = node;
                //process node
                root = node.right;
            }
        }
        return results.ToArray();
    }
}