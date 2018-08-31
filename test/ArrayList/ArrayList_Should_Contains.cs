using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_Contain
    {
        [Fact]
        public void return_true_when_contains()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(position: 0, element: 1);

            // Assert
            Assert.True(list.Contains(1));
        }

        [Fact]
        public void return_false_when_not_contains()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 2);

            // Assert
            Assert.False(list.Contains(1));
        }

        [Fact]
        public void return_false_when_empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Assert
            Assert.False(list.Contains(1));
        }

        [Fact]
        public void return_true_when_contains_empty_element()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(position: 0, element: 1);
            list.Insert(position: 1, element: 1);
            list.Insert(position: 2, element: 2);

            // Assert
            Assert.True(list.Contains(1));
        }
    }
}