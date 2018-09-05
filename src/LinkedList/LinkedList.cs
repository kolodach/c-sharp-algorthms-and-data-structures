using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{
    /// <summary>
    /// Custom Linked List implementation. 
    /// </summary>
    public class LinkedList<T> : IList<T>, IQueue<T>
    {
        // First element of the linked list   
        private LinkedListNode<T> _head;

        // Last element of the linked list
        private LinkedListNode<T> _tail;

        // Currnet number of elements
        private int _count;

        /*
            Returns element at specific index. Iterates through if index is less than 0 or greater or equal then count
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

        /// <summary>
        /// Currnet number of elements
        /// </summary>
        public int Count => _count;


        /// <summary>
        /// Removes all elements from list 
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        /// <summary>
        /// Inserts the element at the start of the list. 
        /// </summary>
        /// <param name="element">The element that being checked</param>
        public bool Contains(T element)
        {
            if (element == null)
                return false;

            bool contains = false;
            var current = _head;
            while (current != null)
            {
                if (element.Equals(current.Value))
                {
                    contains = true;
                    break;
                }
                current = current.Next;
            }
            return contains;
        }

        /// <summary>
        /// Returns index of first occurrence of given element
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Returns index of first occurrence of given element
        /// </summary>
        /// <return>
        /// Index of first occurrence of element if exists, 
        /// -1 if given element does not exists.
        /// </return>
        /// <param name="element">The element being inserted</param>
        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            var index = 0;
            var current = _head;
            while (current != null)
            {
                if (element.Equals(current.Value))
                {
                    break;
                }
                current = current.Next;
                index++;
            }
            if (current == null)
                return -1;
            return index;
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

        /// <summary>
        /// Inserts the element at the specific position. 
        /// </summary>
        /// <param name="element">The element being inserted</param>
        /// <exception cref="System.IndexOutOfRangeException">when index is less than zero or greater than count</exception>  
        public void Insert(int position, T element)
        {
            if (position < 0 || position > _count)
                throw new IndexOutOfRangeException();
            if (position == 0)
            {
                AddFirst(element);
                return;
            }
            if (position == _count)
            {
                AddLast(element);
                return;
            }
            var current = _head;
            int index = 0;
            while (current != null && index != position)
            {
                index++;
                current = current.Next;
            }
            var node = new LinkedListNode<T>(element);
            node.Previous = current.Previous;
            node.Previous.Next = node;
            current.Previous = node;
            node.Next = current;
            _count++;
        }

        /// <summary>
        /// Removes element at given position
        /// </summary>
        /// <param name="position">The position of element being removed</param>
        public bool Remove(int position)
        {
            if (_count == 0)
                return false;
            if (position < 0 || position >= _count)
                throw new IndexOutOfRangeException();
            var current = _head;
            int index = 0;
            while (current != null && index != position)
            {
                index++;
                current = current.Next;
            }
            if (current.Previous != null)
                current.Previous.Next = current.Next;
            else _head = current.Next;
            if (current.Next != null)
                current.Next.Previous = current.Previous;
            else _tail = current.Previous;
            _count--;
            return true;
        }

        // Implements adding to the queue
        public void Enqueue(T item)
        {
            AddLast(item);
        }

        // Implements removing from the queue
        public T Dequeue()
        {
            if(_count == 0)
                throw new InvalidOperationException();
            var top = _head.Value;
            Remove(0);
            return top;
        }

        // Returns first element of the queue
        public T Peek()
        {
            if(_count == 0)
                throw new InvalidOperationException();
            return _head.Value;
        }
    }
}