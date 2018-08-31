using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Insert_Should
    {
        [Fact]
        public void Throw_When_Index_Greater_Than_Count()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act 
            suit.Insert(0, 1);
            suit.Insert(1, 2);
            suit.Insert(2, 3);

            // Assert     
            Assert.Throws<IndexOutOfRangeException>(() => suit.Insert(4, 1));
        }

        [Fact]
        public void Throw_When_Index_Less_Than_Zero()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert     
            Assert.Throws<IndexOutOfRangeException>(() => suit.Insert(-1, 1));
        }

        [Fact]
        public void Insert_When_Empty()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.Insert(0, 1);

            // Assert
            Assert.Equal(1, suit.Count);
            Assert.Equal(1, suit[0]);
        }

        [Fact]
        public void Insert_At_Start()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.Insert(0, 1);
            suit.Insert(0, 2);
            suit.Insert(0, 3);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(3, suit[0]);
            Assert.Equal(2, suit[1]);
            Assert.Equal(1, suit[2]);
        }

        [Fact]
        public void Insert_At_End()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.Insert(0, 1);
            suit.Insert(1, 2);
            suit.Insert(2, 3);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(3, suit[2]);
            Assert.Equal(2, suit[1]);
            Assert.Equal(1, suit[0]);
        }

        [Fact]
        public void Insert_At_Middle()
        {
            // Arrange 
            var suit = new LinkedList<int>();

            // Act
            suit.Insert(0, 2);
            suit.Insert(1, 1);
            suit.Insert(2, 3);

            // Assert
            Assert.Equal(3, suit.Count);
            Assert.Equal(3, suit[2]);
            Assert.Equal(1, suit[1]);
            Assert.Equal(2, suit[0]);
        }
    }
}