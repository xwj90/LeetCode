using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
	public TreeNode DeleteNode(TreeNode root, int key)
	{
		if (root == null)
			return null;
		if (root.val > key)
			root.left = DeleteNode(root.left, key);
		else if (root.val < key)
			root.right = DeleteNode(root.right, key);
		else
		{
			if (root.left == null)
				return root.right;
			else if (root.right == null)
				return root.left;

			root.val = findMin(root.right).val;
			root.right = DeleteNode(root.right, root.val);
		}
		return root;
	}
	public TreeNode findMin(TreeNode root)
	{
		while (root.left != null)
			root = root.left;
		return root;
	}
}