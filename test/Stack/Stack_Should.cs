using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

public class Stack_Should
{
    [Fact]
    public void Push()
    {
        // Arrange 
        var suit = new Stack<int>();

        // Act
        suit.Push(1); 
        suit.Push(2); 
        suit.Push(3); 

        // Assert
        Assert.Equal(3, suit.Count);
    }

    [Fact]
    public void Pop()
    {
        // Arrage
        var suit = new Stack<int>();

        // Act
        suit.Push(2);
        suit.Push(1);
        var top = suit.Pop();

        // Assert
        Assert.Equal(1, suit.Count);
        Assert.Equal(1, top);
    }

    
    [Fact]
    public void Pick()
    {
        // Arrage
        var suit = new Stack<int>();

        // Act
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(2);
        suit.Push(1);
        var top = suit.Peek();

        // Assert
        Assert.Equal(9, suit.Count);
        Assert.Equal(1, top);
    }
}