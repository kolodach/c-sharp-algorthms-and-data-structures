using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{

    public class ArrayList<T> : IList<T>
    {
        private const int _defaultInitialCapacity = 10;
        private T[] _array;
        private int _count;
        private int _capacity;

        public ArrayList(int capacity = _defaultInitialCapacity)
        {
            _capacity = capacity;
            _array = new T[_capacity];
            _count = 0;
        }

        public T this[int i]
        {
            get
            {
                if (i >= _count)
                    throw new IndexOutOfRangeException();
                return _array[i];
            }
        }

        public int Count => _count;

        public bool Contains(T element)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(T element)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int position, T element)
        {
            if(position < 0 || position > _count)
                throw new ArgumentOutOfRangeException(nameof(Insert), nameof(position));
            if(_count + 1 > _capacity)
                ExpandArray();
            for(int i = _count - 1; i >= position; i--)
                _array[i + 1] = _array[i];
            _array[position] = element;
            _count++;
        }

        public void Remove(int position, T element)
        {
            throw new System.NotImplementedException();
        }

        private void ExpandArray()
        {
            if (_capacity != int.MaxValue)
            {
                _capacity = _capacity * 2 <= int.MaxValue
                    ? _capacity * 2
                    : int.MaxValue;
                var oldArray = _array;
                _array = new T[_capacity];
                for(int i = 0; i < _count; i++)
                    _array[i] = oldArray[i];
            }
        }
    }
}