using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForInsert
    {
        public static IEnumerable<object[]> GetDataForInsertValidIntByCountAndIndex()
        {
            var collection = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                2,
                10,
                6,
            };

            collection = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                9,
                10,
                11,
            };
            collection = new MyList<int>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                50,
                10,
                101,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertValidIntByEquals()
        {
            var random = new Random();
            var collection = new MyList<int>();
            var values = new int[1];
            var indexes = new int[1];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(0, 256);
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], values[i]);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[10];
            indexes = new int[10];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(0, 256);
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], values[i]);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[100];
            indexes = new int[100];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(0, 256);
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], values[i]);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertValidClassByEquals()
        {
            var random = new Random();
            var employees = new Employee[1];
            var indexes = new int[1];
            var collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], employees[i]);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            employees = new Employee[10];
            indexes = new int[10];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], employees[i]);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            employees = new Employee[100];
            indexes = new int[100];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], employees[i]);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            employees = new Employee[1000];
            indexes = new int[1000];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = null;
                indexes[i] = random.Next(0, 100);
                collection.Insert(indexes[i], employees[i]);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
        }
    }
}
