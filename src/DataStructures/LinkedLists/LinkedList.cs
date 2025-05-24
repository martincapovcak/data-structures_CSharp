using System;
using System.Collections.Generic;

namespace DataStructures.LinkedLists;

// Generic class for flexibility
public class Node<T>
{
    // Holds the node's data
    public T Value { get; set; }

    // Points to the next node
    // ? Nullable reference (used for last node)
    public Node<T>? Next { get; set; }

    // Sets the value and initializes Next to null
    public Node(T value)
    {

        Value = value;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T>? head;
    private Node<T>? tail;
    private int count;

    public int Count { get => count; }
    public bool IsEmpty { get => count == 0; }

    public LinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    #region Add Methods         // Create
    #endregion

    #region Query Methods       // Read
    #endregion

    #region Delete Methods      // Delete
    #endregion

    #region Structure Methods   // Manipulation
    #endregion

    #region Utility Methods     // Debug / Export
    #endregion
}