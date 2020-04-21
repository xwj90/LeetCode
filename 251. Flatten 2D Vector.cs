public class Vector2D
{
    int i = 0;
    List<int> list = new List<int>();
    public Vector2D(int[][] v)
    {
        if (v != null)
        {
            for (var i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                {
                    for (var j = 0; j < v[i].Length; j++)
                    {
                        list.Add(v[i][j]);
                    }
                }
            }
        }
    }

    public int Next()
    {
        return list[i++];
    }

    public bool HasNext()
    {
        return i < list.Count;
    }
}

/**
 * Your Vector2D object will be instantiated and called as such:
 * Vector2D obj = new Vector2D(v);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
