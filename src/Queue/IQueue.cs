using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Count { get; }
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}