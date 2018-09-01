using System;

namespace AlgorithmsAndDataStructures.Collections
{
    public class Stack<T> : IStack<T>
    {
        private T[] _array;
        private const int DefaultCapacity = 4;
        private int _count;
        private int _top;

        public Stack(int capacity = DefaultCapacity)
        {
            _array = new T[capacity];
            _top = -1;
        }

        public int Count => _count;

        public T Peek()
        {
            return _array[_top];
        }

        public T Pop()
        {
            _count--;
            _top--;
            return _array[_top + 1];
        }

        public void Push(T element)
        {
            int next = _count;

            // Expanding array if need
            if (next >= _array.Length)
            {
                if (_array.Length == int.MaxValue)
                    throw new StackOverflowException();
                var newLength = _array.Length * 2;
                var newArray = new T[newLength > int.MaxValue
                    ? int.MaxValue
                    : newLength];
                for (int i = 0; i < _array.Length; i++)
                    newArray[i] = _array[i];
                _array = newArray;
            }

            _array[next] = element;
            _count++;
            _top++;
        }

        internal T this[int i]
        {
            get
            {
                return _array[i];
            }
        }
    }
}