public interface ISearcher
{
    int Search<K>(K[] sequence, K item) where K : IComparable<K>;
}
