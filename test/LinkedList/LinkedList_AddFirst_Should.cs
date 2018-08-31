using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_AddFirst_Should
    {

        [Fact]
        public void AddWhenEmpty()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.AddFirst(1);

            // Assert
            Assert.Equal(1, suit.Count);
            Assert.Equal(1, suit[0]);
        }

        [Fact]
        public void AddWhenNotEmpty()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.AddFirst(1);
            suit.AddFirst(2);
            suit.AddFirst(3);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(3, suit[0]);
            Assert.Equal(2, suit[1]);
            Assert.Equal(1, suit[2]);
        }
    }
}