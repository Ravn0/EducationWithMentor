using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Generic
{
    public interface IMyCollections<T>
    {
        void Add(T item);

        void InsertInStart(T item);

        void Insert(int index, T item);

        void AddRange(T[] array);

        void InsertRangeInStart(T[] array);

        void InsertRange(int index, T[] array);
    }
}
