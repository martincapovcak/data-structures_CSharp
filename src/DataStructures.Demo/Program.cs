
using DataStructures.LinkedLists;

namespace DataStructures.Demo;

class Program
{
    static void Main(string[] args)
    {

        MyLinkedList<int> l = new MyLinkedList<int>();
        l.AddLast(10);
        l.AddLast(20);
        l.AddLast(30);
        l.AddFirst(40);
        l.Display();

        Console.ReadKey();
    }
}
