using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.Collections
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
    }
    public class SinglyLinkedList<T> : IStack<T>, IEnumerable<T>
    {
        private SinglyLinkedListNode<T> _head;
        private int _count;
        public SinglyLinkedListNode<T> Head => _head;
        public int Count => _count;

        public IEnumerator<T> GetEnumerator()
        {
            var currnet = _head;
            while (currnet != null)
            {
                yield return currnet.Value;
                currnet = currnet.Next;
            }
        }

        public void AddFirst(T element)
        {
            var node = new SinglyLinkedListNode<T>(element);
            node.Next = _head;
            _head = node;
            _count++;
        }

        private void RemoveFirst()
        {
            if(_count != 0) {
                _head = _head.Next;
                _count--;
            }
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        
        public void Reverse()
        {
            SinglyLinkedListNode<T> tmp1, tmp2 = null;
            var current = _head;
            while (current != null)
            {
                tmp1 = current.Next;
                current.Next = tmp2;
                tmp2 = current;
                current = tmp1;
            }
            _head = tmp2;
        }

        public void Push(T element)
        {
            AddFirst(element);
        }

        public T Pop()
        {
            if(_count == 0)
                throw new InvalidOperationException();
            var value = _head.Value;
            RemoveFirst();
            return value;
        }

        public T Pick()
        {
            if(_count == 0)
                throw new InvalidOperationException();
            return _head.Value;
        }
    } 

    public static class LinkedListExtensions
    {
        public static int IndexOf<T>(this SinglyLinkedList<T> list, T element)
        {
            int i = -1;
            if (element != null)
                foreach (var item in list)
                {
                    if (element.Equals(item))
                    {
                        i++;
                        break;
                    }
                    i++;
                }
            return i;
        }

        public static T ElementAt<T>(this SinglyLinkedList<T> list, int index)
        {
            if (index < 0 || index >= list.Count)
                throw new System.IndexOutOfRangeException();
            var current = list.Head;
            var i = 0;
            while (current != null && index != i)
            {
                current = current.Next;
                i++;
            }
            return current.Value;
        }

    }
}