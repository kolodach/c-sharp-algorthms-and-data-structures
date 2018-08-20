using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public class ArrayList_Should_Enumerate
    {
        [Fact]
        public void Keep_Correct_Order()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.Insert(3, 4);
            list.Insert(4, 5);
            list.Insert(5, 6);

            int prevVal = -1;
            int loopTimes = 0;
            bool greaterThanPrevious = true;

            foreach (var item in list)
            {
                loopTimes++;
                if (prevVal > item)
                    greaterThanPrevious = false;
                prevVal = item;
            }

            // Assert
            Assert.True(greaterThanPrevious);
            Assert.Equal(loopTimes, list.Count);
        }

        [Fact]
        public void Not_Throw_When_Empty()
        {
            // Arrange
            var list = new ArrayList<int>();

            // Act
            foreach(var item in list)
                item.ToString();
        }
    }
}