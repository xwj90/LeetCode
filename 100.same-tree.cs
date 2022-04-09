
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Stack<(TreeNode p, TreeNode q)> stack = new();
        stack.Push((p, q));
        while (stack.Any())
        {
            var (n1, n2) = stack.Pop();
            if (n1 == null && n2 == null) continue;
            else if (n1?.val != n2?.val) return false;

            stack.Push((n1.left, n2.left));
            stack.Push((n1.right, n2.right));
        }

        return true;
    }
}

