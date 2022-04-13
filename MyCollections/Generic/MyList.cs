using System;
using System.Text;

namespace MyCollections.Generic
{
    public class MyList<T> : IMyCollection<T>
    {
        private T[] _array = Array.Empty<T>();
        private T[] newArray = Array.Empty<T>();

        private readonly int _defaultCapacity = 8;
        private readonly double _coefficient = 0.3;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return _array[index];
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    _array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public MyList()
        {
            _array = new T[_defaultCapacity];
        }

        public void Add(T item)
        {
            var countObj = 1;
            _array = ResizeArray(countObj);

            _array[Count] = item;
            AddCount(countObj);
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
            var countObj = 1;
            _array = ResizeArray(countObj);
            if (ValidateIndex(index, Count))
            {
                for (int i = Count; i > index; i--)
                {
                    if (i - 1 == index)
                    {
                        _array[i - 1] = item;
                        AddCount(countObj);
                        break;
                    }

                    _array[i] = _array[i - 1];
                }
            }
        }

        public void InsertInStart(T item)
        {
            Insert(0, item);
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                if (result.Length == 0)
                {
                    result.Append($"{_array[i]}");
                }
                else
                {
                    result.AppendFormat(", {0}", _array[i]);
                }
            }

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (obj is MyList<T> other)
            {
                other = (MyList<T>)obj;
                result = true;

                if (Count != other.Count)
                {
                    result = false;
                }

                for (int i = 0; i < Count && result; i++)
                {
                    if (!this._array[i].Equals(other._array[i]))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        private T[] ResizeArray(int countObjects)
        {
            if (_array.Length <= (Count + countObjects))
            {
                var tempArray = (T[])_array.Clone();
                var additionalLength = (int)(_array.Length * _coefficient);
                if (additionalLength <= countObjects)
                {
                    additionalLength += countObjects;
                }

                var newLength = _array.Length + additionalLength;
                _array = new T[newLength];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    _array[i] = tempArray[i];
                }
            }

            return _array;
        }

        private bool ValidateIndex(int index, int count)
        {
            bool result = index >= 0 && index < count;

            return result;
        }

        private void AddCount(int countObjects)
        {
            Count += countObjects;
        }
    }
}