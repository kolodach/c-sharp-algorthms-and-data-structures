namespace AlgorithmsAndDataStructures.Collections
{
    public interface IList<T> : IReadOnlyList<T>
    {
        void Insert(int position, T element);

        void Remove(int position, T element);
    }
}