namespace DataStructures.LinkedLists;
interface ILinkedList<T>
{
    void AddFirst(T value);
    void AddLast(T value);
    void AddAt(int index, T value);

    bool Contains(T value);
    int IndexOf(T value);

    T GetAt(int index);

    T FindOf(T value);
    T FindBy(Func<T, bool> predicate);
    List<T> FindManyBy(Func<T, bool> predicate);

    bool RemoveFirst();
    bool RemoveLast();
    bool RemoveAt(int index);
    bool RemoveOf(T value);
    bool RemoveBy(Func<T, bool> predicate);
    bool RemoveManyBy(Func<T, bool> predicate);

    T TakeFirst();
    T TakeLast();
    T TakeAt(int index);
    T TakeBy(Func<T, bool> predicate);
    List<T> TakeManyBy(Func<T, bool> predicate);

    void Clear();
    void Reverse();

    T[] ToArray();
    void PrintTable();
    void PrintValues();
}