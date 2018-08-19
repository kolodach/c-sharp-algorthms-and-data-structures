using AlgorithmsAndDataStructures.Collections;
using Xunit;

namespace Test.AlgorithmsAndDataStructures.Collections
{
    public partial class ArrayList_Should_Insert
    {
        [Fact]
        public void WhenEmpty()
        {
            // Arrange
            IList<int> list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);

            // Assert
            Assert.Equal(1, list.Count);
            Assert.Equal(1, list[0]);
        }

        [Fact]
        public void AtTheStartWhenNotEmpty()
        {
            // Arrange
            IList<int> list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(0, 2);

            // Assert
            Assert.Equal(2, list.Count);
            Assert.Equal(2, list[0]);
            Assert.Equal(1, list[1]);
        }

        [Fact]
        public void AtTheEnd()
        {
            // Arrange
            IList<int> list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);

            // Assert
            Assert.Equal(2, list.Count);
            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
        }

        [Fact]
        public void AtTheMiddle()
        {
            // Arrange
            IList<int> list = new ArrayList<int>();

            // Act
            list.Insert(0, 1);
            list.Insert(1, 3);
            list.Insert(1, 2);

            // Assert
            Assert.Equal(3, list.Count);
            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
            Assert.Equal(3, list[2]);
        }

        [Fact]
        void ThrowWhenIndexOutOfRange()
        {
            // Arrange
            IList<int> list = new ArrayList<int>();

            // Act, Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => list.Insert(1, 1));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => list.Insert(-1, 1));
        }

        [Fact]
        void GreaterThanInitialCount()
        {
            // Arrange
            IList<int> list = new ArrayList<int>(capacity: 3);

            // Act
            for (int i = 0; i < 9; i++)
                list.Insert(i, i + 1);
            
            // Assert
            for (int i = 0; i < 9; i++)
                Assert.Equal(i+1, list[i]);
        }

    }
}