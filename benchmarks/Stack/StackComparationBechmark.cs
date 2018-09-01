using System;
using AlgorithmsAndDataStructures.Collections;


namespace Benchmark
{
    public class StackCompationBenchmark
    {
        public StackCompationBenchmark()
        {
            PushTest(new SinglyLinkedList<int>(), 1000);
            PushTest(new Stack<int>(), 1000);
            PushTest(new DefaultStackWrapper<int>(), 1000);
            System.Console.WriteLine("------------------------------------");
            PushTest(new SinglyLinkedList<int>(), 1_0_000);
            PushTest(new Stack<int>(), 1_0_000);
            PushTest(new DefaultStackWrapper<int>(), 1_0_000);
            System.Console.WriteLine("------------------------------------");
            PushTest(new SinglyLinkedList<int>(), 1_00_000);
            PushTest(new Stack<int>(), 1_00_000);
            PushTest(new DefaultStackWrapper<int>(), 1_00_000);
            System.Console.WriteLine("------------------------------------");
            PushTest(new SinglyLinkedList<int>(), 1_000_000);
            PushTest(new Stack<int>(), 1_000_000);
            PushTest(new DefaultStackWrapper<int>(), 1_000_000);
            System.Console.WriteLine("------------------------------------");
            PushTest(new SinglyLinkedList<int>(), 100_000_000);
            PushTest(new Stack<int>(), 100_000_000);
            PushTest(new DefaultStackWrapper<int>(), 100_000_000);
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