using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemove
    {
        public static IEnumerable<object[]> GetDataForRemoveValidIntByCountAndIndex()
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
                49,
                50,
                0,
                51,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var qtyRemoves = 1;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
            collection = new MyList<int>(array);
            qtyRemoves = 10;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
            collection = new MyList<int>(array);
            qtyRemoves = 90;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var qtyRemoves = 1;
            var collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 10;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 50;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 99;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveStartValidIntByCountAndIndex()
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
                50,
                9,
                120,
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
                49,
                1,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveStartValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var qtyRemoves = 1;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
            collection = new MyList<int>(array);
            qtyRemoves = 10;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
            collection = new MyList<int>(array);
            qtyRemoves = 90;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
            collection = new MyList<int>(array);
            qtyRemoves = 100;
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                collection,
                qtyRemoves,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveStartValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var qtyRemoves = 1;
            var collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 10;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 50;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
            qtyRemoves = 99;
            collection = new MyList<Employee>(array);
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            yield return new object[]
            {
                qtyRemoves,
                collection,
            };
        }

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

        public static IEnumerable<object[]> GetDataForRemoveRangeStartValidIntByCountAndIndex()
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
                50,
                10,
                122,
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
                49,
                1,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeStartValidIntByEquals()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var collection = new MyList<int>(array);
            var count = 1;
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 10;
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 50;
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 100;
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                collection,
                count,
            };
            collection = new MyList<int>(array);
            count = 300;
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                collection,
                count,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveRangeStartValidClassByEquals()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            var count = 7;
            var collection = new MyList<Employee>(array);
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 61;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 100;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                count,
                collection,
            };
            count = 200;
            collection = new MyList<Employee>(array);
            collection.RemoveRangeStart(count);

            yield return new object[]
            {
                count,
                collection,
            };
        }

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
            var array = new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 };
            var collection = new MyList<int>(array);
            var value = 1;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = -2;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = 0;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = 5;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = 7;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = 9;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
            collection = new MyList<int>(array);
            value = 50;
            collection.RemoveFirst(value);

            yield return new object[]
            {
                collection,
                value,
            };
        }

        public static IEnumerable<object[]> GetDataForRemoveFirstValidClassByEquals()
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
            var collection = new MyList<Employee>(array);
            collection.RemoveFirst(value);

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "ban", Age = 16 };
            collection = new MyList<Employee>(array);
            collection.RemoveFirst(value);

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "jack", Age = 12 };
            collection = new MyList<Employee>(array);
            collection.RemoveFirst(value);

            yield return new object[]
            {
                value,
                collection,
            };
            value = new Employee { Name = "Oliver", Age = 16 };
            collection = new MyList<Employee>(array);
            collection.RemoveFirst(value);

            yield return new object[]
            {
                value,
                collection,
            };
            value = null;
            collection = new MyList<Employee>(array);
            collection.RemoveFirst(value);

            yield return new object[]
            {
                value,
                collection,
            };
        }

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
            var array = new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 1, 1, 5 };
            var collection = new MyList<int>(array);
            var value = 1;
            var countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = -2;
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = 0;
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = 5;
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = 7;
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = 9;
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                collection,
                value,
                countRemoves,
            };
            collection = new MyList<int>(array);
            value = 50;
            countRemoves = collection.RemoveAll(value);

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
            var collection = new MyList<Employee>(array);
            var countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
            value = new Employee { Name = "ban", Age = 16 };
            collection = new MyList<Employee>(array);
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
            value = new Employee { Name = "jack", Age = 12 };
            collection = new MyList<Employee>(array);
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
            value = new Employee { Name = "Oliver", Age = 16 };
            collection = new MyList<Employee>(array);
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
            value = null;
            collection = new MyList<Employee>(array);
            countRemoves = collection.RemoveAll(value);

            yield return new object[]
            {
                value,
                countRemoves,
                collection,
            };
        }
    }
}
