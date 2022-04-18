namespace MyCollections.Generic
{
    public interface IMyCollection<T>
    {
        int Count { get; }

        T this[int index] { get; set; }

        void Add(T item);

        void Insert(int index, T item);

        void InsertInStart(T item);

        void AddRange(T[] array);

        void InsertRange(int index, T[] array);

        void InsertRangeInStart(T[] array);
    }
}