public class MedianFinder
{

    /** initialize your data structure here. */
    int id = 0;
    SortedSet<(int value, int id)> min = new SortedSet<(int value, int id)>();
    SortedSet<(int value, int id)> max = new SortedSet<(int value, int id)>();
    public MedianFinder()
    {

    }

    public void AddNum(int num)
    {
        if (min.Count == max.Count) min.Add((num, id++));
        else max.Add((num, id++));

        if (min.Any() && max.Any())
        {
            var min_min = min.Min;
            var max_max = max.Max;
            if (min_min.value < max_max.value)
            {
                min.Remove(min.Min);
                min.Add(max_max);
                max.Remove(max.Max);
                max.Add(min_min);
            }
        }
    }

    public double FindMedian()
    {
        if (min.Count == max.Count)
        {
            return (min.Min.value + max.Max.value) / 2.0;
        }
        else
        {
            return min.Min.value;
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
