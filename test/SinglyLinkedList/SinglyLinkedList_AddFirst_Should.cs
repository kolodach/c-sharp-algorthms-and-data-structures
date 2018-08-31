using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;
namespace Test.AlgorithmsAndDataStructures
{
    public class SinglyLinkedList_AddFirst_Should
    {
        [Fact]
        public void Add()
        {
            // Arrange
            var suit = new SinglyLinkedList<int>();

            // Act
            suit.AddFirst(3);
            suit.AddFirst(2);
            suit.AddFirst(1);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(0, suit.IndexOf(1));
            Assert.Equal(1, suit.IndexOf(2));
            Assert.Equal(2, suit.IndexOf(3));
        }
    }
}