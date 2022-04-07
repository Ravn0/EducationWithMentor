using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections.Generic
{
    public class MyList<T> : IMyCollections<T>
    {
        private T[] _array = Array.Empty<T>();
        public T[] MyPropertyArray
        {
            get
            {
                return _array;
            }
        }
        public void Add(T item)
        {
            var newArray = new T[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = item;
            _array = newArray;
        }

        public void AddRange(T[] collection)
        {
            var newArray = new T[_array.Length + collection.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < collection.Length; i++)
            {
                newArray[_array.Length + i] = collection[i];
            }
            _array = newArray;
        }

        public void Insert(int index, T item)
        {
            var newArray = new T[_array.Length + 1];
            if (index > _array.Length)
            {
                return;
            }
            for (int i = 0; i < _array.Length && i < index; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[index] = item;
            for (int i = index; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

        public void InsertInStart(T item)
        {
            var newArray = new T[_array.Length + 1];
            newArray[0] = item;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }

        public void InsertRange(int index, T[] collection)
        {
            var newArray = new T[_array.Length + collection.Length];
            if (index > _array.Length)
            {
                return;
            }
            for (int i = 0; i < _array.Length && i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < collection.Length; i++)
            {
                newArray[index + i] = collection[i];
            }
            for (int i = index; i < _array.Length; i++)
            {
                newArray[i + collection.Length] = _array[i];
            }
            _array = newArray;
        }

        public void InsertRangeInStart(T[] collection)
        {
            InsertRange(0, collection);
        }
    }
}
