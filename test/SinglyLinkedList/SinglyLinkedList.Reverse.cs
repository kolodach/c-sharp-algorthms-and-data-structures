using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public partial class SinglyLinkedList
    {
        [Fact]
        public void Reverse()
        {
            // Arrange
            var suit = new SinglyLinkedList<int>();
        
            // Act
            suit.AddFirst(3);
            suit.AddFirst(2);
            suit.AddFirst(1);
            suit.Reverse();
        
            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(3, suit.ElementAt(0));
            Assert.Equal(2, suit.ElementAt(1));
            Assert.Equal(1, suit.ElementAt(2));
            Assert.Null(suit.Head.Next.Next.Next);
        }        
    }
}