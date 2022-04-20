using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForAddAndInsert
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
            int[] values = new int[1];
            for (int i = 0; i < values.Length; i++)
            {
                collection.Add(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[10];
            for (int i = 0; i < values.Length; i++)
            {
                collection.Add(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
                collection,
            };
            collection = new MyList<int>();
            values = new int[100];
            for (int i = 0; i < values.Length; i++)
            {
                collection.Add(i);
                values[i] = i;
            }

            yield return new object[]
            {
                values,
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

        public static IEnumerable<object[]> GetDataForAddRangeValidIntByCountAndIndex()
        {
            var random = new Random();
            var maxCapacity = 10;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacity)];
            var index = random.Next(values.Length);
            var value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length,
                index,
                value,
            };

            maxCapacity = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length,
                index,
                value,
            };
            maxCapacity = 1000;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length,
                index,
                value,
            };
            maxCapacity = 10;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < 3; i++)
            {

                collection.AddRange(values);
            }

            index = random.Next(collection.Count);
            for (int i = 0; i < collection.Count; i++)
            {
                if (i == index)
                {
                    value = collection[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length+collection.Count,
                index,
                value,
            };
        }
        public static IEnumerable<object[]> GetDataForAddRangeValidIntByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new int[values.GetLength(1)];

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
        }
        public static IEnumerable<object[]> GetDataForAddRangeValidClassByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new Employee[employees.GetLength(1)];
            var collection = new MyList<Employee>();

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = null;
                }

                collection.AddRange(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeInStartValidIntByCountAndIndex()
        {
            var random = new Random();
            var maxCapacity = 10;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacity)];
            var index = random.Next(values.Length);
            var value = 0;
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length+collection.Count,
                index,
                value,
            };

            maxCapacity = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length+collection.Count,
                index,
                value,
            };
            maxCapacity = 1000;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                values,
                values.Length+collection.Count,
                index,
                value,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeInStartValidIntByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new int[values.GetLength(1)];
            collection.Add(0);
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];
            collection.Add(0);
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];
            collection.Add(0);
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                values,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeInStartValidClassByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new Employee[employees.GetLength(1)];
            var collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            collection.Add(new Employee { Name = "Alex", Age = 23 });
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = null;
                }

                collection.InsertRangeInStart(myArray);
            }

            yield return new object[]
            {
                employees,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeValidIntByCountAndIndex()
        {
            var random = new Random();
            var maxCapacity = 10;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacity)];
            var index = random.Next(values.Length);
            var value = 0;
            for (int i = 0; i < 5; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                2,
                values,
                values.Length+collection.Count,
                index+2,
                value,
            };

            maxCapacity = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;
            for (int i = 0; i < 5; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                3,
                values,
                values.Length+collection.Count,
                index+3,
                value,
            };
            maxCapacity = 1000;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacity)];
            index = random.Next(values.Length);
            value = 0;
            for (int i = 0; i < 5; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                if (i == index)
                {
                    value = values[i];
                }
            }

            yield return new object[]
            {
                collection,
                4,
                values,
                values.Length+collection.Count,
                index+4,
                value,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeValidIntByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var collection = new MyList<int>();
            var values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new int[values.GetLength(1)];
            var indexes = new int[values.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];
            indexes = new int[values.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            collection = new MyList<int>();
            values = new int[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new int[values.GetLength(1)];
            indexes = new int[values.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j] = random.Next(-100, 100);
                }

                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                values,
                collection,
            };
        }

        public static IEnumerable<object[]> GetDataForInsertRangeValidClassByEquals()
        {
            var random = new Random();
            var maxCapacityHeight = 5;
            var maxCapacityWidth = 5;
            var employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            var myArray = new Employee[employees.GetLength(1)];
            var collection = new MyList<Employee>();
            var indexes = new int[employees.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }
                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 10;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            indexes = new int[employees.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }
                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            indexes = new int[employees.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = new Employee { Name = ((Names)random.Next(0, 201)).ToString(), Age = random.Next(1, 100) };
                }
                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
            }

            yield return new object[]
            {
                indexes,
                employees,
                collection,
            };
            maxCapacityHeight = 10;
            maxCapacityWidth = 100;
            employees = new Employee[random.Next(1, maxCapacityHeight), random.Next(1, maxCapacityWidth)];
            myArray = new Employee[employees.GetLength(1)];
            collection = new MyList<Employee>();
            indexes = new int[employees.GetLength(0)];
            for (int i = 0; i < 100; i++)
            {
                collection.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    myArray[j] = employees[i, j] = null;
                }
                indexes[i] = random.Next(0, 100);
                collection.InsertRange(indexes[i], myArray);
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