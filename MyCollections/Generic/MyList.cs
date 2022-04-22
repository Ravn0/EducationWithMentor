using System;
using System.Text;

namespace MyCollections.Generic
{
    public class MyList<T> : IMyCollection<T>
    {
        private T[] _array = Array.Empty<T>();

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
            Count = 0;
            _array = new T[_defaultCapacity];
        }

        public MyList(T value)
        {
            Count = 1;
            _array = new T[_defaultCapacity];
            _array[0] = value;
        }

        public MyList(T[] value)
        {
            if (value != null)
            {
                Count = value.Length;
                _array = new T[value.Length + _defaultCapacity];
                for (int i = 0; i < Count; i++)
                {
                    _array[i] = value[i];
                }
            }
            else
            {
                Count = 0;
                _array = new T[_defaultCapacity];
            }
        }

        /// <summary>
        /// Adds an element to the end of the MyList<T>
        /// </summary>
        /// <param name="item">Value to be added</param>
        public void Add(T item)
        {
            var countObj = 1;
            _array = ResizeArray(countObj);

            _array[Count] = item;
            AddCount(countObj);
        }

        /// <summary>
        /// Insert an element into the MyList<T> at the specified index
        /// </summary>
        /// <param name="index">The index at which the value is inserted</param>
        /// <param name="item">Value to be added</param>
        public void Insert(int index, T item)
        {
            if (ValidateIndex(index, Count))
            {
                var countObj = 1;
                _array = ResizeArray(countObj);
                for (int i = Count; i > index; i--)
                {
                    _array[i] = _array[i - 1];

                    if (i - 1 == index)
                    {
                        _array[i - 1] = item;
                        AddCount(countObj);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Adds an element to the start of the MyList<T>
        /// </summary>
        /// <param name="item">Value to be added</param>
        public void InsertInStart(T item)
        {
            Insert(index: 0, item);
        }

        /// <summary>
        /// Adds the elements of the array to the end of the MyList<T>
        /// </summary>
        /// <param name="array">Array to be added</param>
        public void AddRange(T[] array)
        {
            var countObj = array.Length;
            _array = ResizeArray(countObj);

            for (int i = 0; i < array.Length; i++)
            {
                _array[Count + i] = array[i];
            }

            AddCount(countObj);
        }

        /// <summary>
        /// Insert array elements into the MyList<T> at the specified index
        /// </summary>
        /// <param name="index">The index at which the value is inserted</param>
        /// <param name="array">Array to be added</param>
        public void InsertRange(int index, T[] array)
        {
            if (ValidateIndex(index, Count))
            {
                var countObj = array.Length;
                _array = ResizeArray(countObj);
                var actualIndex = Count + array.Length - 1;

                for (int i = Count - 1; i >= index && actualIndex >= index + array.Length; i--)
                {
                    _array[actualIndex--] = _array[i];
                }

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    _array[actualIndex--] = array[i];
                }

                AddCount(countObj);
            }
        }

        /// <summary>
        /// Insert array elements at the start of the MyList<T>
        /// </summary>
        /// <param name="array">Array to be added</param>
        public void InsertRangeInStart(T[] array)
        {
            InsertRange(index: 0, array);
        }

        public void Remove()
        {
            var countObj = 1;
            RemoveCount(countObj);
            _array = ResizeArray(-countObj);
        }

        public void RemoveStart()
        {
            RemoveAt(index: 0);
        }

        public void RemoveAt(int index)
        {
            if (ValidateIndex(index, Count))
            {
                var countObj = 1;
                for (int i = index; i < Count; i++)
                {
                    _array[i] = _array[i + 1];
                }

                RemoveCount(countObj);
                _array = ResizeArray(-countObj);
            }
        }

        public void RemoveRange(int count)
        {
            var countObj = count;
            RemoveCount(countObj);
            _array = ResizeArray(-countObj);
        }

        public void RemoveRangeStart(int count)
        {
            RemoveRangeAt(index: 0, count);
        }

        public void RemoveRangeAt(int index, int count)
        {
            if (ValidateIndex(index, Count))
            {
                var countObj = count;
                for (int i = index; i < Count; i++)
                {
                    if (i + count <= Count)
                    {
                        _array[i] = _array[i + count];
                    }
                }

                if (index + count > Count)
                {
                    countObj = Count - index;
                }

                RemoveCount(countObj);
                _array = ResizeArray(-countObj);
            }
        }

        public void RemoveFirst(T value)
        {
            throw new NotImplementedException();
        }

        public int RemoveAll(T value)
        {
            throw new NotImplementedException();
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
                    if (_array[i] == null && other._array[i] == null)
                    {
                        continue;
                    }

                    if (!_array[i].Equals(other._array[i]))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Change the number of elements in an array while keeping the contents
        /// </summary>
        /// <param name="countObjects">The number of objects to insert into the array</param>
        /// <returns></returns>
        private T[] ResizeArray(int countObjects)
        {
            //Increase array size
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

            //Decrease array size
            if (countObjects < 0 && Count * 2 <= _array.Length)
            {
                var tempArray = (T[])_array.Clone();
                var newLength = Count + _defaultCapacity;
                _array = new T[newLength];
                for (int i = 0; i < _array.Length; i++)
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

        private void RemoveCount(int countObjects)
        {
            Count -= countObjects;
            if (Count < 0)
            {
                Count = 0;
            }
        }
    }
}