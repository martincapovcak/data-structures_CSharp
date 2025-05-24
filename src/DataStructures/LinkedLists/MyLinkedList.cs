namespace DataStructures.LinkedLists;

// Generic class for flexibility
public class Node<T>
{
    // Holds the node's data
    public T Element { get; set; }

    // Points to the next node
    // ? Nullable reference (used for last node)
    public Node<T>? Next { get; set; }

    // Sets the value and initializes Next to null
    public Node(T element)
    {

        Element = element;
        Next = null;
    }
}

public class MyLinkedList<T>
{
    private Node<T>? head;
    private Node<T>? tail;
    private int count;

    public int Count { get => count; }
    public bool IsEmpty { get => count == 0; }

    public MyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    #region Add Methods         // Create

    public void AddLast(T element)
    {
        Node<T> node = new Node<T>(element);

        if (this.IsEmpty)
            head = node;
        else
            tail.Next = node;

        tail = node;
        count++;
    }

    public void AddFirst(T element)
    {
        Node<T> node = new Node<T>(element);

        if (this.IsEmpty)
            tail = node;
        else
            node.Next = head;

        head = node;
        count++;
    }

    #endregion

    #region Query Methods       // Read
    #endregion

    #region Delete Methods      // Delete
    #endregion

    #region Structure Methods   // Manipulation
    #endregion

    #region Utility Methods     // Debug / Export

    public void Display()
    {
        Node<T> p = head;
        int index = 0;

        Console.Write($"LinkedList<{typeof(T).Name}> ");
        Console.Write($"[Count = {count}] ");
        Console.Write("{ ");

        while (p != null)
        {
            Console.Write($"[{index++}] {p.Element}");
            Console.Write(" -> ");

            if(p.Next == null) Console.Write("∅");

            p = p.Next;
        }

        Console.Write(" }");
        Console.WriteLine();
    }

    #endregion
}