using System;

public interface IStack<T>
{
    void Push(T element);

    T Pop();

    T Pick();

    int Count { get; }
}