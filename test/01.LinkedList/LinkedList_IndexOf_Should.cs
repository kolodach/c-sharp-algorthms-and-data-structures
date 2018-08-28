using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_IndexOf_Should
    {
        [Fact]
        public void Return_Negative_One_When_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert
            Assert.Equal(-1, suit.IndexOf(1));
        }

        [Fact]
        public void Return_Negative_One_When_Not_Contains()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);

            // Assert
            Assert.Equal(-1, suit.IndexOf(4));
        }

        [Fact]
        public void Return_Index_Of_First_Occurrence()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);

            // Assert
            Assert.Equal(1, suit.IndexOf(2));
        }
    }
}