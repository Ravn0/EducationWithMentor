using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForRemoveStart
    {
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
    }
}
