using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemoveAt
    {
        public static IEnumerable<object[]> GetDataForRemoveAtValidIntByCountAndIndex()
        {
            var array = new int[10];
            var value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value++;
            }

            var collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                2,
                7,
                8,
                9,
            };
            array = new int[100];
            value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value += 2;
            }

            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                50,
                10,
                22,
                99,
            };
            array = new int[100];
            value = -50;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value++;
            }

            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                99,
                0,
                -50,
                99,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveAtValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var index = 1;
            collection.RemoveAt(index);

            yield return new object[]
            {
                collection,
                index,
            };
            collection = new MyList<int>(array);
            index = 10;
            collection.RemoveAt(index);

            yield return new object[]
            {
                collection,
                index,
            };
            collection = new MyList<int>(array);
            index = 50;
            collection.RemoveAt(index);

            yield return new object[]
            {
                collection,
                index,
            };
            collection = new MyList<int>(array);
            index = 99;
            collection.RemoveAt(index);

            yield return new object[]
            {
                collection,
                index,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveAtValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var indexes = new int[] { 5, 6, 9, 7 };
            var collection = new MyList<Employee>(array);
            for (int i = 0; i < indexes.Length; i++)
            {
                collection.RemoveAt(indexes[i]);
            }

            yield return new object[]
            {
                indexes,
                collection,
            };
            indexes = new int[] { 8, 1, 5, 7, 21, 58, 61 };
            collection = new MyList<Employee>(array);
            for (int i = 0; i < indexes.Length; i++)
            {
                collection.RemoveAt(indexes[i]);
            }

            yield return new object[]
            {
                indexes,
                collection,
            };
            indexes = new int[] { 51, 1, 24, 68, 92, 54, 74, 12 };
            collection = new MyList<Employee>(array);
            for (int i = 0; i < indexes.Length; i++)
            {
                collection.RemoveAt(indexes[i]);
            }

            yield return new object[]
            {
                indexes,
                collection,
            };
            indexes = new int[] { 99, 98, 97, 96, 0, 4, 5, 1, 8, 10, 14 };
            collection = new MyList<Employee>(array);
            for (int i = 0; i < indexes.Length; i++)
            {
                collection.RemoveAt(indexes[i]);
            }

            yield return new object[]
            {
                indexes,
                collection,
            };
        }
    }
}
