using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Generic
{
    interface IMyCollections<T>
    {
        void Add(T item);
        void InsertInStart(T item);
        void Insert(int index, T item);
        void AddRange(T[] collection);
        void InsertRangeInStart(T[] item);
        void InsertRange(int index, T[] collection);
    }
}
