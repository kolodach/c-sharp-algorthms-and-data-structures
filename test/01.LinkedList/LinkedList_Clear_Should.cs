using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Clear_Should
    {
        [Fact]
        public void When_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act 
            suit.Clear();

            // Assert
            Assert.Equal(0, suit.Count);
        }

        [Fact]
        public void When_Not_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act 
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);
            suit.Clear();

            // Assert
            Assert.Equal(0, suit.Count);
        }
    }
}