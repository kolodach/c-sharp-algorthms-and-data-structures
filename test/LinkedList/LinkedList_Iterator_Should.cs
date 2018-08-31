using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class LinkedList_Iterator_Should
    {
        [Fact]
        public void Iterate_When_Empty()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act, Assert
            foreach (var item in suit)
                item.ToString();
        }

        [Fact]
        public void Keep_Order()
        {
            // Arrange
            var suit = new LinkedList<int>();

            // Act
            suit.AddLast(1);
            suit.AddLast(2);
            suit.AddLast(3);

            // Assert
            int index = 0;
            foreach (var item in suit)
            {
                item.Equals(suit.IndexOf(index));
                index++;
            }
        }
    }
}