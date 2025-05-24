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

    // Creates a new node with the given value at the very beginning of the linked list
    public void AddFirst(T value) { throw new NotImplementedException(); }

    // Creates a new node with the given value at the end of the linked list
    public void AddLast(T value) { throw new NotImplementedException(); }

    // Creates a new node with the given value at the specified index
    public void AddAt(int index, T value) { throw new NotImplementedException(); }

    #endregion

    #region Query Methods       // Read

    // Checks if a node with the given value exists in the list
    public bool Contains(T value) { throw new NotImplementedException(); }

    // Returns the index of the node with the given value
    public int IndexOf(T value) { throw new NotImplementedException(); }

    // Returns the value at the specified index
    public T GetAt(int index) { throw new NotImplementedException(); }

    // Returns the first node that matches the given value
    public T FindFirstOf(T value) { throw new NotImplementedException(); }

    // Returns the first value that satisfies the given condition
    public T FindFirstBy(Func<T, bool> predicate) { throw new NotImplementedException(); }

    // Returns all values that satisfy the given condition
    public List<T> FindAllBy(Func<T, bool> predicate) { throw new NotImplementedException(); }

    #endregion

    #region Delete Methods      // Delete

    // Removes all nodes that match the given value
    public bool RemoveAllOf(T value) { throw new NotImplementedException(); }

    // Removes the node at the specified index
    public bool RemoveAt(int index) { throw new NotImplementedException(); }

    // Removes and returns the last node in the linked list
    public T PopLast() { throw new NotImplementedException(); }

    #endregion

    #region Structure Methods   // Manipulation

    // Clears all nodes from the list
    public void Clear() { throw new NotImplementedException(); }

    // Reverses the order of nodes in the linked list
    public void Reverse() { throw new NotImplementedException(); }

    #endregion

    #region Utility Methods     // Debug / Export

    // Converts the linked list to an array
    public T[] ToArray() { throw new NotImplementedException(); }

    // Prints the linked list as a formatted table
    public void PrintTable() { throw new NotImplementedException(); }

    // Outputs all values in the linked list to the console
    public void PrintValues() { throw new NotImplementedException(); }

    #endregion
}