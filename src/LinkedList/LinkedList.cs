using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{
    /// <summary>
    /// Custom Linked List implementation. 
    /// </summary>
    public class LinkedList<T> : IList<T>
    {
        // First element of the linked list   
        private LinkedListNode<T> _head;

        // Last element of the linked list
        private LinkedListNode<T> _tail;

        // Currnet number of elements
        private int _count;

        /*
            Returns element at specific index. Iterates throught if index is less than 0 or greater or equal then count
            System.IndexOutOfRangeException will be thrown.
         */
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();

                int i = 0;
                var current = _head;
                while (current != null && i != index)
                {
                    i++;
                    current = current.Next;
                }

                return current.Value;
            }
        }

        public int Count => _count;

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

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


        /// <summary>
        /// Inserts the element at the start of the list. 
        /// </summary>
        /// <param name="element">The element being inserted</param>
        public void AddFirst(T element)
        {
            var node = new LinkedListNode<T>(element);
            node.Next = _head;
            if (_tail == null)
                _tail = node;
            else _head.Previous = node;
            _head = node;
            _count++;
        }

        /// <summary>
        /// Inserts the element at the end of the list. 
        /// </summary>
        /// <param name="element">The element being inserted</param>
        public void AddLast(T element)
        {
            var node = new LinkedListNode<T>(element);
            node.Previous = _tail;
            if (_head == null)
                _head = node;
            else _tail.Next = node;
            _tail = node;
            _count++;
        }

        public void Insert(int position, T element)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(int position)
        {
            throw new System.NotImplementedException();
        }
    }
}