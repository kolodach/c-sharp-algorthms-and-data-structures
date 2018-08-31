using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_ElementAt_Should
    {
        [Fact]
        public void Throw_When_Out_Of_Range()
        {
            // Arrange
            var suite = new LinkedList<int>();

            // Act
            suite.AddFirst(0);

            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => suite[1]);
        }

        [Fact]
        public void Trow_When_Empty()
        {
            // Arrange
            var suite = new LinkedList<int>();

            // Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => suite[1]);
        }

        [Fact]
        public void Return_Correct_Value()
        {
            // Arrange
            var suite = new LinkedList<int>();

            // Act
            suite.AddFirst(3);
            suite.AddFirst(2);
            suite.AddFirst(1);

            // Assert
            Assert.Equal(1, suite[0]);
        }
    }
}