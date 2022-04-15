using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceData
    {
        public static IEnumerable<object[]> GetDataForAddValidIntByCountAndIndex()
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
                1,
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
                10,
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
                100,
            };
        }

        public static IEnumerable<object[]> GetDataForAddValidIntByEquals()
        {
            var collection = new MyList<int>();
            int[] value = new int[1];
            for (int i = 0; i < value.Length; i++)
            {
                collection.Add(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[10];
            for (int i = 0; i < value.Length; i++)
            {
                collection.Add(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[100];
            for (int i = 0; i < value.Length; i++)
            {
                collection.Add(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForAddValidClassByEquals()
        {
            var random = new Random();
            var employees = new Employee[1];
            var collection = new MyList<Employee>();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.Add(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[10];
            collection = new MyList<Employee>();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.Add(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[100];
            collection = new MyList<Employee>();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                collection.Add(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            employees = new Employee[1000];
            collection = new MyList<Employee>();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = null;
                collection.Add(employees[i]);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
        }

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
            int[] value = new int[1];
            collection.Add(0);
            for (int i = 0; i < value.Length; i++)
            {
                collection.InsertInStart(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[10];
            collection.Add(0);
            for (int i = 0; i < value.Length; i++)
            {
                collection.InsertInStart(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[100];
            collection.Add(0);
            for (int i = 0; i < value.Length; i++)
            {
                collection.InsertInStart(i);
                value[i] = i;
            }

            yield return new object[]
            {
                value,
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
            int[] value = new int[1];
            int[] index = new int[1];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = random.Next(0, 256);
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], value[i]);
            }

            yield return new object[]
            {
                index,
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[10];
            index = new int[10];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = random.Next(0, 256);
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], value[i]);
            }

            yield return new object[]
            {
                index,
                value,
                collection,
            };
            collection = new MyList<int>();
            value = new int[100];
            index = new int[100];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = random.Next(0, 256);
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], value[i]);
            }

            yield return new object[]
            {
                index,
                value,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertValidClassByEquals()
        {
            var random = new Random();
            var employees = new Employee[1];
            var index = new int[1];
            var collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], employees[i]);
            }

            yield return new object[]
            {
                index,
                employees,
                collection,
            };
            employees = new Employee[10];
            index = new int[10];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], employees[i]);
            }

            yield return new object[]
            {
                index,
                employees,
                collection,
            };
            employees = new Employee[100];
            index = new int[100];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], employees[i]);
            }

            yield return new object[]
            {
                index,
                employees,
                collection,
            };
            employees = new Employee[1000];
            index = new int[1000];
            collection = new MyList<Employee>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = null;
                index[i] = random.Next(0, 100);
                collection.Insert(index[i], employees[i]);
            }

            yield return new object[]
            {
                index,
                employees,
                collection,
            };
        }
    }
}