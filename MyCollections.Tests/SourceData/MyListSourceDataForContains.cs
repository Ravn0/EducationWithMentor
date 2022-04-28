using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForContains
    {
        public static IEnumerable<object[]> GetDataForContainsValidInt()
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
                true,
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
                true,
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
                false,
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
                true,
            };
        }

        public static IEnumerable<object[]> GetDataForContainsValidClass()
        {
            var employee = new Employee { Name = "Levi", Age = 17 };
            var result = true;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = new Employee { Name = "Leo", Age = 35 };
            result = true;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = new Employee { Name = "Alex", Age = 23 };
            result = false;

            yield return new object[]
            {
                employee,
                result,
            };
            employee = null;
            result = false;

            yield return new object[]
            {
                employee,
                result,
            };
        }
    }
}
