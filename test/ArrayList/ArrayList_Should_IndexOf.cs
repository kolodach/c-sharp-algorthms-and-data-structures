using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_IndexOf
    {
        [Fact]
        public void Return_Correct_Index()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);

            // Assert
            Assert.Equal(1, list.IndexOf(2));
        }

        [Fact]
        public void Return_Index_Of_First_Occurence()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Insert(4, 4);

            // Assert
            Assert.Equal(3, list.IndexOf(4));
        }


        [Fact]
        public void Return_Negative_One_When_Not_Exists()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Insert(4, 4);

            // Assert
            Assert.Equal(-1, list.IndexOf(5));
        }

        [Fact]
        public void Return_Negative_One_When_Empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Assert
            Assert.Equal(-1, list.IndexOf(5));
        }
    }
}