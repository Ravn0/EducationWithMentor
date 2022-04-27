using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemoveFirst
    {
        public static IEnumerable<object[]> GetDataForRemoveFirstValidIntByCountAndIndex()
        {
            var array = new int[] { 0, 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 8, 9 };
            var collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                2,
                2,
                3,
                14,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                4,
                8,
                7,
                14,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                8,
                13,
                9,
                14,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                10,
                13,
                8,
                15,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveFirstValidIntByEquals()
        {
            var collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });
            var value = 1;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });
            value = -2;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });
            value = 0;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 6, 7, 7, 7, 7, 8, 9, 9 });
            value = 5;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 8, 9, 9 });
            value = 7;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9 });
            value = 9;

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });
            value = 50;

            yield return new object[]
            {
                collection,
                value,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveFirstValidClassByEquals()
        {
            var value = new Employee { Name = "alex", Age = 23 };
            var collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "ban", Age = 16 };
            collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "jack", Age = 12 };
            collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "Oliver", Age = 16 };
            collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            yield return new object[]
            {
                value,
                collection,
            };
            value = null;
            collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            yield return new object[]
            {
                value,
                collection,
            };
        }
    }
}
