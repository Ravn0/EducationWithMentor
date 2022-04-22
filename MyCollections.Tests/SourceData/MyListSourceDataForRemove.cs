﻿using System;
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
    }
}
