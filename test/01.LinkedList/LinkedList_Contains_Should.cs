using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Contails_Should
    {
        [Fact]
        public void Return_False_When_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert
            Assert.False(suit.Contains(1));
        }

        [Fact]
        public void Return_False_When_Not_Exists()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(2); 
            
            // Assert
            Assert.False(suit.Contains(1));
        }

        [Fact]
        public void Return_False_When_Null()
        {
            // Arrange
            var suit = new LinkedList<int?>();

            // Act
            suit.AddLast(1); 
            suit.AddLast(null); 
            
            // Assert
            Assert.False(suit.Contains(null));
        }

        [Fact]
        public void Return_True_When_Exists()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1); 
            
            //Assert
            Assert.True(suit.Contains(1));
        }

        [Fact]
        public void Return_True_When_Duplicates_Exists()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1); 
            suit.AddLast(1); 
            
            //Assert
            Assert.True(suit.Contains(1));
        }
    }
}