using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{

    public IList<int> LargestValues(TreeNode root)
    {
        LargestValues(root, 0);
        return LargestValues_dict.OrderBy(p => p.Key).Select(p => p.Value).ToList();
    }
    Dictionary<int, int> LargestValues_dict = new Dictionary<int, int>();
    public void LargestValues(TreeNode root, int level = 0)
    {
        if (root != null)
        {
            if (!LargestValues_dict.ContainsKey(level))
                LargestValues_dict[level] = root.val;
            else
                LargestValues_dict[level] = Math.Max(LargestValues_dict[level], root.val);
            LargestValues(root.left, level + 1);
            LargestValues(root.right, level + 1);
        }
    }
}