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

    // o(1)
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

    // o(1)
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

    // o(n)
    public void AddAt(T element, int index)
    {
        if (index <= 0 || index >= count - 1)
        {
            Console.WriteLine("Invalid Index");
            return;
        }
       
        Node<T> node = new Node<T>(element);
        Node<T> p = head;
        int i = 1;

        while (i < index)
        {
            p = p.Next;
            i++;
        }

        node.Next = p.Next;
        p.Next = node;

        count++;
    }

    #endregion

    #region Query Methods       // Read
    #endregion

    #region Delete Methods      // Delete

    // o(1)
    public T RemoveFirst()
    {
        if (IsEmpty)
        {
            // TODO: Consider throwing error?
            Console.WriteLine("List is empty");
            return default;
        }

        T element = head.Element;

        head = head.Next;
        count--;

        if (IsEmpty)
            tail = null;

        return element;
    }

    public T RemoveLast() { return default; }

    public T RemoveAt() { return default; }

    #endregion

    #region Structure Methods   // Manipulation
    #endregion

    #region Utility Methods     // Debug / Export

    // o(n)
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

            if (p.Next == null) Console.Write("∅");

            p = p.Next;
        }

        Console.Write(" }");
        Console.WriteLine();
    }

    #endregion
}