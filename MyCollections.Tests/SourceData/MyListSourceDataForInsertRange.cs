using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceDataForInsertRange
    {
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
