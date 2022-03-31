public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        
        var map = new Dictionary<int, int>();
        var list=new SortedList<int,int>();
        var minScore= -1;
        var res=new List<int>();
        for(var i=1;i<=m;i++)
        {
            list[i] =i-1;
        }

        var res=new List<int>();
        foreach(var q in queries)
        {
            var pos = list.IndexOfKey(q);
            res.Add(pos);
            list[q] = minScore--;
        }
         
         return list.ToArray();
    }
}