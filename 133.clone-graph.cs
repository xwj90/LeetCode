public class Solution
{
    Dictionary<int, Node> dict = new Dictionary<int, Node>();
    public Node CloneGraph(Node node)
    {
        return Clone(node);
    }
    public Node Clone(Node node)
    {
        if (node == null) return null;
        if (dict.ContainsKey(node.val)) return dict[node.val];

        var clone = new Node(node.val);
        dict[node.val]= clone;
        foreach(var n in node.neighbors){
            clone.neighbors.Add(Clone(n));
        }
        return clone;
    }
}
// @lc code=end

