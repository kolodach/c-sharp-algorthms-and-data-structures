using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Dequeue_Should
    {
        [Fact]
        public void ThrowWhenEmpty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert
            Assert.Throws<InvalidOperationException>(() => suit.Dequeue());
        }

        [Fact]
        public void ReturnFirstElement()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.Enqueue(1);
            suit.Enqueue(2);
            suit.Enqueue(3);
            var top = suit.Dequeue();

            // Assert
            Assert.Equal(2, suit.Count);
            Assert.Equal(2, suit[0]);
            Assert.Equal(3, suit[1]);
        }
    }
}