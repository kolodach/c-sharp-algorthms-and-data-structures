using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{
    public interface IEnumerable<T>
    {
        IEnumerator<T> GetEnumerator();
    }
}