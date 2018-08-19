using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_Get
    {
        [Fact]
        public void Throw_When_Index_Out_Of_Range_When_Empty()
        {
            // Arrane
            var list = new ArrayList<int>();

            // Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => list[0]);
        }

        [Fact]
        public void throw_when_index_out_of_range_and_not_empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);

            // Assert
            Assert.Throws<IndexOutOfRangeException>(()=> list[1]);
        }
    }
}