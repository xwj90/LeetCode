using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }

    public static TreeNode Create(int[] s, int i = 0)
    {
        if (i >= s.Length)
            return null;
        TreeNode node = new TreeNode(s[i]);
        node.left = Create(s, (i + 1) * 2 - 1);
        node.right = Create(s, (i + 1) * 2);
        return node;
    }
    public override string ToString()
    {
        var s = this.val+"";
        if (this.left != null)
            s += "-" + this.left;
        if (this.right != null)
            s += "-" + this.right;

        return s;
    }
}

