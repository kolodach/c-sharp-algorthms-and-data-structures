using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_Remove
    {
        [Fact]
        public void AtTheStart()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);

            // Assert
            Assert.True(list.Remove(0));
            Assert.Equal(2, list.Count);
            Assert.Equal(2, list[0]);
            Assert.Equal(3, list[1]);
        }

        [Fact]
        public void AtTheEnd()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);

            // Assert
            Assert.True(list.Remove(2));
            Assert.Equal(2, list.Count);
            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
        }

        [Fact]
        public void AtTheMiddle()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);

            // Assert
            Assert.True(list.Remove(1));
            Assert.Equal(2, list.Count);
            Assert.Equal(1, list[0]);
            Assert.Equal(3, list[1]);
        }

        [Fact]
        public void Last()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Act
            list.Insert(0, 1);

            // Assert
            Assert.True(list.Remove(0));
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void when_out_of_range()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Act
            list.Insert(0, 2);

            // Assert
            Assert.False(list.Remove(1));
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void not_throw_when_empty()
        {
            // Arrange 
            var list = new ArrayList<int>(shrinkEnabled: true);

            // Assert
            Assert.False(list.Remove(1));
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void shrink()
        {
            // Arrange
            var list = new ArrayList<int>(capacity: 3, shrinkEnabled: true);

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Remove(0);
            list.Remove(0);

            // Assert
            Assert.Equal(3, list.Capacity);
        }

        [Fact]
        public void not_shrink_when_disabled()
        {
            // Arrange
            var list = new ArrayList<int>(capacity: 3, shrinkEnabled: false);

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Remove(3);

            // Assert
            Assert.Equal(6, list.Capacity);
        }

        [Fact]
        public void not_shrink_less_than_initial_capacity()
        {
            // Arrange
            var list = new ArrayList<int>(capacity: 6, shrinkEnabled: true);

            // Act 
            for (int i = 0; i < 18; i++)
                list.Insert(0, i);

            for (int i = 1; i < 18; i++)
                list.Remove(0);

            // Assert
            Assert.Equal(6, list.Capacity);
        }
    }
}