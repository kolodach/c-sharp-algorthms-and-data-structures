using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_AddLast_Should
    {
        [Fact]
        public void WhenEmpty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);

            // Assert
            Assert.Equal(1, suit.Count);
            Assert.Equal(1, suit[0]);
        }

        [Fact]
        public void WhenNotEmpty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(1, suit[0]);
            Assert.Equal(2, suit[1]);
            Assert.Equal(3, suit[2]);
        }
    }
}