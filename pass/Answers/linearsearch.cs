public class LinearSearch : ISearcher
{
    public int Search<K>(K[] sequence, K item) where K : IComparable<K>
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i].CompareTo(item) == 0)
            {
                return i;
            }
        }
        return -1; // Item not found
    }
}
