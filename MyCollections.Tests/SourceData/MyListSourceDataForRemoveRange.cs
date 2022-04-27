using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemoveRange
    {
        public static IEnumerable<object[]> GetDataForRemoveRangeValidIntByCountAndIndex()
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
                7,
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
                99,
                0,
                -50,
                1,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var count = 1;
            collection.RemoveRange(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 10;
            collection.RemoveRange(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 50;
            collection.RemoveRange(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 100;
            collection.RemoveRange(count);

            yield return new object[]
            {
                collection,
                count,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var count = 7;
            var collection = new MyList<Employee>(array);
            collection.RemoveRange(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 61;
            collection = new MyList<Employee>(array);
            collection.RemoveRange(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 100;
            collection = new MyList<Employee>(array);
            collection.RemoveRange(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 200;
            collection = new MyList<Employee>(array);
            collection.RemoveRange(count);

            yield return new object[]
            {
                count,
                collection,
            };
        }
    }
}
