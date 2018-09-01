using System;
using Xunit;
using AlgorithmsAndDataStructures.Collections;

public class Stack_Should
{
    [Fact]
    public void Push()
    {
        // Arrange 
        var suit = new SinglyLinkedList<int>();

        // Act
        suit.Push(1); 
        suit.Push(2); 
        suit.Push(3); 

        // Assert
        Assert.Equal(3, suit.Count);
        Assert.Equal(3, suit.ElementAt(0));
        Assert.Equal(2, suit.ElementAt(1));
        Assert.Equal(1, suit.ElementAt(2));
    }

    [Fact]
    public void Pop()
    {
        // Arrage
        var suit = new SinglyLinkedList<int>();

        // Act
        suit.Push(2);
        suit.Push(1);
        var top = suit.Pop();

        // Assert
        Assert.Equal(1, suit.Count);
        Assert.Equal(2, suit.ElementAt(0));
        Assert.Equal(1, top);
    }

    
    [Fact]
    public void Pick()
    {
        // Arrage
        var suit = new SinglyLinkedList<int>();

        // Act
        suit.Push(2);
        suit.Push(1);
        var top = suit.Pick();

        // Assert
        Assert.Equal(2, suit.Count);
        Assert.Equal(1, suit.ElementAt(0));
        Assert.Equal(2, suit.ElementAt(1));
        Assert.Equal(1, top);
    }
}