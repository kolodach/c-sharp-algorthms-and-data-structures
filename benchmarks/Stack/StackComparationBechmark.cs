using System;
using AlgorithmsAndDataStructures.Collections;


namespace Benchmark
{
    public class StackCompationBenchmark
    {
        public StackCompationBenchmark()
        {
            for (int i = 1000; i <= 100_000_000; i *= 10)
            {
                PushTest(new SinglyLinkedList<int>(), i);
                PushTest(new Stack<int>(), i);
                PushTest(new DefaultStackWrapper<int>(), i);
                System.Console.WriteLine("------------------------------------");
            }

            for (int i = 1000; i <= 100_000_000; i *= 10)
            {
                PopTest(new SinglyLinkedList<int>(), i);
                PopTest(new Stack<int>(), i);
                PopTest(new DefaultStackWrapper<int>(), i);
                System.Console.WriteLine("------------------------------------");
            }
        }

        public void PopTest(IStack<int> stack, int count)
        {
            System.Console.WriteLine($"{stack.ToString()}: Push {count} elements ");
            for (int i = 0; i < count; i++)
                stack.Push(i);
            System.Console.WriteLine($"{stack.ToString()}: Pop {count} elements ");            
            var startTime = DateTime.Now;
             for (int i = 0; i < count; i++)
                stack.Pop();
            System.Console.WriteLine($"Time total: {(DateTime.Now - startTime).TotalMilliseconds}");
        }

        private void PushTest(IStack<int> stack, int count)
        {
            System.Console.WriteLine($"{stack.ToString()}: Push {count} elements ");
            var startTime = DateTime.Now;
            for (int i = 0; i < count; i++)
                stack.Push(i);
            System.Console.WriteLine($"Time total: {(DateTime.Now - startTime).TotalMilliseconds}");
        }
    }
}