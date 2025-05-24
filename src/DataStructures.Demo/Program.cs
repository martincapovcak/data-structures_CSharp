
using DataStructures.LinkedLists;

namespace DataStructures.Demo;

class Program
{
    static void Main(string[] args)
    {

        MyLinkedList<int> l = new MyLinkedList<int>();
        int element;

        l.AddLast(10);
        l.AddLast(20);
        l.AddLast(30);
        l.Display();

        l.AddFirst(40);
        l.AddFirst(50);
        l.AddFirst(60);
        l.Display();

        l.AddAt(111, 1);
        l.Display();

        l.TryRemoveFirst(out element);
        Console.WriteLine("Deleted element: {0}", element);
        l.Display();

        Console.ReadKey();
    }
}
