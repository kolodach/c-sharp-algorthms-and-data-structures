namespace AlgorithmsAndDataStructures.Collections
{
    public interface IReadOnlyList<T> : IEnumerable<T>, ICollection<T>
    {
        T this[int i] { get; }

        int IndexOf(T element);

        bool Contains(T element);
    }
}