using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForInsertInStart
    {
        public static IEnumerable<object[]> GetDataForInsertInStartValidIntByCountAndIndex()
        {
            var collection = new MyList<int>();
            for (int i = 0; i < 1; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                2,
                0,
            };
            collection = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                11,
                0,
            };
            collection = new MyList<int>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                101,
                0,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertInStartValidIntByEquals()
        {
            var collection = new MyList<int>();
            var values = new int[1];
            collection.Add(0);
            for (int i = 0; i < values.Length; i++)
            {
                collection.InsertInStart(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[10];
            collection.Add(0);
            for (int i = 0; i < values.Length; i++)
            {
                collection.InsertInStart(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[100];
            collection.Add(0);
            for (int i = 0; i < values.Length; i++)
            {
                collection.InsertInStart(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertInStartValidClassByEquals()
        {
            var random = new Random();
            var employees = new Employee[1];
            var collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.InsertInStart(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[10];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.InsertInStart(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[100];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.InsertInStart(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[1000];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = null;
                collection.InsertInStart(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
        }
    }
}
