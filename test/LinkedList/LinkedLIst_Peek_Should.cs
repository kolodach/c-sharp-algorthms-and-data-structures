using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Peek_Should
    {
        [Fact]
        public void ThrowWhenEmpty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert
            Assert.Throws<InvalidOperationException>(() => suit.Peek());
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
            var top = suit.Peek();

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(1, suit[0]);
            Assert.Equal(2, suit[1]);
            Assert.Equal(3, suit[2]);
        }
    }
}