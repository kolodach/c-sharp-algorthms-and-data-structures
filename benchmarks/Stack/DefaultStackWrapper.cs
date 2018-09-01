using AlgorithmsAndDataStructures.Collections;

namespace Benchmark
{
    public class DefaultStackWrapper<T> : IStack<T>
    {
        private System.Collections.Generic.Stack<T> stack;

        public DefaultStackWrapper()
        {
            stack = new System.Collections.Generic.Stack<T>();
        }

        public int Count => stack.Count;

        public T Peek()
        {
            return stack.Peek();
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public void Push(T element)
        {
            stack.Push(element);
        }

        public override string ToString()
        {
            return stack.ToString();
        }
    }
}