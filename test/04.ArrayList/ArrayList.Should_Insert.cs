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
    } 
}