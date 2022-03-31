public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var dict = new Dictionary<int, Node>();
        for (var i = 0; i < numCourses; i++)
            dict[i] = new Node() { Value = i };
        foreach (var item in prerequisites)
        {
            var child = dict[item[0]];
            var parent = dict[item[1]];
            child.Parents.Add(parent.Value);
            parent.Children.Add(child.Value);
        }

        var output = new List<int>();
        var s = new List<Node>(dict.Where(p => !p.Value.Parents.Any()).Select(p => p.Value));
        while (s.Any())
        {
            var newList = new List<Node>();
            foreach (var node in s)
            {
                output.Add(node.Value);
                foreach (var childid in node.Children)
                {
                    var child = dict[childid];
                    child.Parents.Remove(node.Value);
                    if (!child.Parents.Any())
                        newList.Add(child);
                }
            }
            s = newList;
        }


        return output.Count == numCourses ? output.ToArray() : new int[0];
    }
}
public class Node
{
    public int Value;
    public HashSet<int> Parents = new HashSet<int>();
    public HashSet<int> Children = new HashSet<int>();
}
// @lc code=end

