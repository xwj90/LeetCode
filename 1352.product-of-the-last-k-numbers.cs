public class ProductOfNumbers
{
    List<int> list = new List<int>() { 1 };

    public void Add(int num)
    {
        if (num > 0)
            list.Add(list.Last() * num);
        else
            list = new List<int>() { 1 };
    }

    public int GetProduct(int k)
    {
        if (k < list.Count)
            return list.Last() / list[list.Count - k - 1];
        else
            return 0;
    }
}
