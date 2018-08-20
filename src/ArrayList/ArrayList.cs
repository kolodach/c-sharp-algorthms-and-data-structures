using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{

    public class ArrayList<T> : IList<T>
    {
        private readonly int _initialCapacity;
        private const float _expandFactor = 2.0f;
        private readonly bool _shrinkEnabled;
        private T[] _array;
        private int _count;
        private int _capacity;

        public ArrayList(int capacity = 10, bool shrinkEnabled = false)
        {
            _capacity = capacity;
            _initialCapacity = _capacity;
            _array = new T[_capacity];
            _count = 0;
            _shrinkEnabled = shrinkEnabled;
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

        public int Capacity => _capacity;

        public bool Contains(T element)
        {
            var contains = false;
            foreach (var item in _array)
                if (item.Equals(element))
                {
                    contains = true;
                    break;
                }
            return contains;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < _count; i++)
                yield return _array[i];
        }

        public int IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
                if (_array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            return index;
        }

        public void Insert(int position, T element)
        {
            if (position < 0 || position > _count)
                throw new ArgumentOutOfRangeException(nameof(Insert), nameof(position));
            if (_count + 1 > _capacity)
                ExpandArray();
            for (int i = _count - 1; i >= position; i--)
                _array[i + 1] = _array[i];
            _array[position] = element;
            _count++;
        }

        public bool Remove(int position)
        {
            if (position < 0 || position >= _count)
                return false;
            for (int i = position; i < _count; i++)
                _array[i] = _array[i + 1];
            ShrinkArray();
            _count--;
            return true;
        }

        public void Clear()
        {
            _capacity = _initialCapacity;
            _array = new T[_capacity];
            _count = 0;
        }

        private void ShrinkArray()
        {
            bool shouldShrink = _shrinkEnabled
            && _capacity / (float)_count >= _expandFactor
            && _capacity / _expandFactor >= _initialCapacity;

            if (shouldShrink)
            {
                _capacity = (int)Math.Round(_capacity / _expandFactor);
                var oldArray = _array;
                _array = new T[_capacity];
                for (int i = 0; i < _count; i++)
                    _array[i] = _array[i];
            }
        }

        private void ExpandArray()
        {
            if (_capacity != int.MaxValue)
            {
                var nextCapacity = (int)Math.Round(_capacity * _expandFactor);
                _capacity = nextCapacity <= int.MaxValue
                    ? nextCapacity
                    : int.MaxValue;
                var oldArray = _array;
                _array = new T[_capacity];
                for (int i = 0; i < _count; i++)
                    _array[i] = oldArray[i];
            }
        }
    }
}