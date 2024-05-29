public class List<T>
{
    private T[] _items;
    public ISearcher Searcher { get; set; }

    public List(int size)
    {
        _items = new T[size];
        Searcher = new DefaultSearcher();
    }

    public T this[int index]
    {
        get { return _items[index]; }
        set { _items[index] = value; }
    }

    public int Length => _items.Length;

    private class DefaultSearcher : ISearcher
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
}
