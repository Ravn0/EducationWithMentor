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
        private T[] newArray = Array.Empty<T>();

        public T[] MyPropertyArray
        {
            get
            {
                return _array;
            }
        }

        public void Add(T item)
        {
            newArray = new T[_array.Length + 1];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[_array.Length] = item;

            _array = newArray;
        }

        public void AddRange(T[] array)
        {
            newArray = new T[_array.Length + array.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                newArray[_array.Length + i] = array[i];
            }

            _array = newArray;
        }

        public void Insert(int index, T item)
        {
            newArray = new T[_array.Length + 1];

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
            newArray = new T[_array.Length + 1];

            newArray[0] = item;

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }

            _array = newArray;
        }

        public void InsertRange(int index, T[] array)
        {
            newArray = new T[_array.Length + array.Length];

            if (index > _array.Length)
            {
                return;
            }

            for (int i = 0; i < _array.Length && i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                newArray[index + i] = array[i];
            }

            for (int i = index; i < _array.Length; i++)
            {
                newArray[i + array.Length] = _array[i];
            }

            _array = newArray;
        }

        public void InsertRangeInStart(T[] array)
        {
            InsertRange(0, array);
        }
    }
}
