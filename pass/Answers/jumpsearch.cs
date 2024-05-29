public class JumpSearch : ISearcher
{
    public int Search<K>(K[] sequence, K item) where K : IComparable<K>
    {
        int length = sequence.Length;
        int step = (int)Math.Sqrt(length);
        int prev = 0;

        while (sequence[Math.Min(step, length) - 1].CompareTo(item) < 0)
        {
            prev = step;
            step += (int)Math.Sqrt(length);
            if (prev >= length)
            {
                return -1;
            }
        }

        for (int i = prev; i < Math.Min(step, length); i++)
        {
            if (sequence[i].CompareTo(item) == 0)
            {
                return i;
            }
        }

        return -1; // Item not found
    }
}
