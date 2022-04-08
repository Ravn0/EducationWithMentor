using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Generic
{
    public interface IMyCollection<T>
    {
        int Count { get; }
        
        T this[int index] { get; set; }
        
        void Add(T item);

        void InsertInStart(T item);

        void Insert(int index, T item);

        void AddRange(T[] array);

        void InsertRangeInStart(T[] array);

        void InsertRange(int index, T[] array);
    }
}