/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
    Queue<char> q=new Queue<char>();
    public int Read(char[] buf, int n) {
        while(q.Count<=n)
        {
            var cs= new Char[4];
            var count = Read4(cs);
            if(count==0) break;
            for(var i=0;i<count;i++)
                q.Enqueue(cs[i]);
        }
        
        var res =new List<char>();
        while(res.Count<n && q.Any())
        {
            res.Add(q.Dequeue());
        }
        for(var i=0;i<res.Count;i++)
            buf[i]=res[i];
        
        return res.Count;        
    }
}