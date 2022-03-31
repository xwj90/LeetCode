public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null) return null;
        var list = new List<Node>() { root };
        while (list.Any())
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                list[i].next = list[i + 1];
            }
            var arr = new List<Node>();
            foreach (var item in list)
            {
                if (item.left != null) arr.Add(item.left);
                if (item.right != null) arr.Add(item.right);
            }
            list = arr;
        }
        return root;
    }
}
// @lc code=end

