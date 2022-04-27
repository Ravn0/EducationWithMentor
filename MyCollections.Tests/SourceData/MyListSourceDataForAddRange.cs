using System;
using System.Collections.Generic;
using MyCollections.Generic;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.SourceData
{
    class MyListSourceDataForAddRange
    {
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
    }
}
