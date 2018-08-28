using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Remove_Should
    {
        [Fact]
        public void False_When_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert   
            Assert.False(suit.Remove(0));
        }

        [Fact]
        public void Throw_When_Out_Of_Range()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);

            // Assert   
            Assert.Throws<IndexOutOfRangeException>(() => suit.Remove(1));
        }

        [Fact]
        public void Remove_When_Not_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);
            suit.Remove(0);

            // Assert  
            Assert.Equal(2, suit.Count);
            Assert.Equal(2, suit[0]);
            Assert.Equal(3, suit[1]);
        }
    }
}