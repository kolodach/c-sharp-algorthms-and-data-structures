using System;

namespace AlgorithmsAndDataStructures.Collections
{
    public interface IStack<T>
    {
        void Push(T element);

        T Pop();

        T Peek();

        int Count { get; }
    }
}