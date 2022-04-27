using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemoveAll
    {
        public static IEnumerable<object[]> GetDataForRemoveAllValidIntByCountAndIndex()
        {
            var array = new int[] { 0, 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 8, 9, 0, 0, 4, 8, 9, 9 };
            var collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                2,
                1,
                2,
                3,
                20,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                0,
                3,
                8,
                7,
                18,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                8,
                5,
                13,
                4,
                16,
            };
            collection = new MyList<int>(array);

            yield return new object[]
            {
                collection,
                10,
                0,
                13,
                8,
                21,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveAllValidIntByEquals()
        {
            var collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 5 });
            var value = 1;
            var countRemoves = 3;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, 1, 1, 5 });
            value = -2;
            countRemoves = 3;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 1, 1, 5 });
            value = 0;
            countRemoves = 2;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 1, 1 });
            value = 5;
            countRemoves = 2;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 8, 9, 9, -2, 1, 1, 5 });
            value = 7;
            countRemoves = 6;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 7, 7, -2, 1, 1, 5 });
            value = 9;
            countRemoves = 2;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 1, 1, 5 });
            value = 50;
            countRemoves = 0;

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveAllValidClassByEquals()
        {
            var array = new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },};

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
            var countRemoves = 1;

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
            value = new Employee { Name = "ban", Age = 16 };
            collection = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});
            countRemoves = 2;

            yield return new object[]
            {
                value,
                countRemoves,
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
            new Employee { Name = "oliver", Age = 24 },});
            countRemoves = 3;

            yield return new object[]
            {
                value,
                countRemoves,
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
            countRemoves = 0;

            yield return new object[]
            {
                value,
                countRemoves,
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
            countRemoves = 0;

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
        }
    }
}
