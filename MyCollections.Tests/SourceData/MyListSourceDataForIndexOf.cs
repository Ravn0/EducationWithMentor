using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForIndexOf
    {
        public static IEnumerable<object[]> GetDataForIndexOfValidInt()
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
                8,
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
                8,
                3,
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
                13,
                -1,
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
                -10,
                40,
            };
        }

        public static IEnumerable<object[]> GetDataForIndexOfValidClass()
        {
            var employee = new Employee { Name = "Levi", Age = 17 };
            var result = 17;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = new Employee { Name = "Leo", Age = 35 };
            result = 35;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = new Employee { Name = "Alex", Age = 23 };
            result = -1;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = null;
            result = -1;

            yield return new object[]
            {
                employee,
                result,
            };
        }
    }
}
