namespace AlgorithmsAndDataStructures.Collections
{
    public interface ICollection<T> : IEnumerable<T>
    {
        int Count { get; }
    }
}