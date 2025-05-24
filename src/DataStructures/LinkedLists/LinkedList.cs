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

    // Creates a new node with given value as param at the end of a linked-list
    public void Append(T value) { }

    // Creates a new node with given value as param at the very begining of i linked-list
    public void Prepend(T value) { }

    // Creates new node at certain index with given value
    public void AddAt(int index, T value) { }

    // Checks if value exists
    public bool Contains(T value) { return false; }

    // Searches for node with value of given param. Returns node index
    public int IndexOf(T value) { return -1; }

    // Searches for node at given index as param. Returns node value
    public T ElementAt(int index) { throw new NotImplementedException(); }

    // Removes every node from linked-list which value match the param
    public bool Remove(T value) { return false; }

    // Removes node at certain index from linked-list
    public bool RemoveAt(int index) { return false; }

    // Removes last node from linked-list and returnes it
    public T Pop() { throw new NotImplementedException(); }

    // Resets the list
    public void Clear() { }

    // Reverse nodes order in the linked-list
    public void Reverse() { }

    // Converts linked-list structure to an array
    public T[] ToArray() { return Array.Empty<T>(); }

    // Prints linked-list as a table to console
    public void Print() { }

    // Outputs all values to the console
    public void PrintAll() { }
}