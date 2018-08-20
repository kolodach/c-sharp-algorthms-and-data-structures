using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_Clrear
    {
        [Fact]
        public void When_Not_Empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Clear();

            // Assert
            Assert.Equal(0, list.Count);
            Assert.Equal(10, list.Capacity);
        }

        [Fact]
        public void When_Empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Clear();

            // Assert
            Assert.Equal(0, list.Count);
            Assert.Equal(10, list.Capacity);
        }

    }
}