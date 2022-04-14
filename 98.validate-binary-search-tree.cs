
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        var list = new List<int>();
        InOrder(root, list);
        for (var i = 1; i < list.Count; i++)
        {
            if (list[i - 1] >= list[i])
                return false;
        }
        return true;
    }
    public void InOrder(TreeNode root, List<int> list)
    {
        if (root != null)
        {
            InOrder(root.left, list);
            list.Add(root.val);
            InOrder(root.right, list);
        }
    }
}

// solution to search entire tree
// public class Solution
// {
//     public bool IsValidBST(TreeNode root)
//     {
//         var status = true;
//         SearchBST(root, ref status);
//         return status;
//     }
//     public (int min, int max) SearchBST(TreeNode root, ref bool isValid)
//     {
//         var min = root.val;
//         var max = root.val;
//         if (root.left != null)
//         {
//             var (minLeft, maxLeft) = SearchBST(root.left, ref isValid);
//             if (maxLeft >= root.val)
//                 isValid = false;
//             min = Math.Min(min, minLeft);
//         }
//         if (root.right != null)
//         {
//             var (minRight, maxRight) = SearchBST(root.right, ref isValid);
//             if (minRight <= root.val)
//                 isValid = false;
//             max = Math.Max(max, maxRight);
//         }
//         if (root.left == null && root.right == null)
//         {
//             return (root.val, root.val);
//         }


//         return (min, max);
//     }
// }


