namespace AlgorithmsAndDataStructures.Collections
{
    /// <summary>
    /// Represents the Linked List node. 
    /// Contains reference to previous and next element and stored value.
    /// </summary>
    public sealed class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Reference to previous element
        /// </summary>
        public LinkedListNode<T> Previous { get; set; }

        /// <summary>
        /// Reference to next element
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        /// <summary>
        /// Stored Value
        /// </summary>
        public T Value { get; set; }
    }
}