namespace DataStructures.LinkedLists;

// Generic class for flexibility
public class Node
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

public class LinkedList
{ 
        
}