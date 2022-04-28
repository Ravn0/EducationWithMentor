using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    class MyListSourceDataForRemoveRangeAt
    {
        public static IEnumerable<object[]> GetDataForRemoveRangeAtValidIntByCountAndIndex()
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
                5,
                2,
                7,
                9,
                8,
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
                20,
                50,
                10,
                22,
                50,
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
                50,
                99,
                0,
                -50,
                50,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeAtValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var index = 5;
            var count = 1;
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                collection,
                index,
                count,
            };
            collection = new MyList<int>(array);
            index = 20;
            count = 10;
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                collection,
                index,
                count,
            };
            collection = new MyList<int>(array);
            index = 50;
            count = 30;
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                collection,
                index,
                count,
            };
            collection = new MyList<int>(array);
            index = 20;
            count = 100;
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                collection,
                index,
                count,
            };
            collection = new MyList<int>(array);
            index = 60;
            count = 50;
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                collection,
                index,
                count,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeAtValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var index = 4;
            var count = 7;
            var collection = new MyList<Employee>(array);
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                index,
                count,
                collection,
            };
            index = 12;
            count = 61;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                index,
                count,
                collection,
            };
            index = 50;
            count = 61;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                index,
                count,
                collection,
            };
            index = 60;
            count = 100;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeAt(index, count);

            yield return new object[]
            {
                index,
                count,
                collection,
            };
        }
    }
}
