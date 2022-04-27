using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForInsertRangeInStart
    {
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
    }
}
