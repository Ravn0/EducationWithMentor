using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForFind
    {
        public static IEnumerable<object[]> GetDataForFindValidInt()
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
                18,
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
                28,
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
                40,
                -10,
            };
        }

        public static IEnumerable<object[]> GetDataForFindValidClass()
        {
            var employee = new Employee { Name = "Levi", Age = 17 };
            var index = 17;

            yield return new object[]
            {
                employee,
                index,
            };
            employee = new Employee { Name = "Leo", Age = 35 };
            index = 35;

            yield return new object[]
            {
                employee,
                index,
            };
            employee = new Employee { Name = "Elias", Age = 52 };
            index = 52;

            yield return new object[]
            {
                employee,
                index,
            };
            employee = new Employee { Name = "Roman", Age = 76 };
            index = 76;

            yield return new object[]
            {
                employee,
                index,
            };
        }
    }
}
