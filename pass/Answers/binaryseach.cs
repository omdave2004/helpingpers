public class BinarySearch : ISearcher
{
    public int Search<K>(K[] sequence, K item) where K : IComparable<K>
    {
        int left = 0;
        int right = sequence.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = sequence[mid].CompareTo(item);

            if (comparison == 0)
            {
                return mid;
            }
            if (comparison < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Item not found
    }
}
