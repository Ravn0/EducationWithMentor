using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListInsertRangeInStartTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListInsertRangeInStartTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 1, 10, 3)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 3, 4, 5)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 4, -5, 8)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 2, 100, 5)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, 0, 11)]
        [InlineData(new int[] { -1, 0, 1 }, 2, 1, 4)]
        public void InsertRangeInStart_Valid_IntByCountAndIndex1(int[] value, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            _collectionInt.InsertRangeInStart(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRangeInStart.GetDataForInsertRangeInStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForInsertRangeInStart))]
        public void InsertRangeInStart_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int[] values, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.InsertRangeInStart(values);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRangeInStart.GetDataForInsertRangeInStartValidIntByEquals), MemberType = typeof(MyListSourceDataForInsertRangeInStart))]
        public void InsertRangeInStart_Valid_IntByEquals(int[,] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.InsertRangeInStart(myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(5, new string[] { "tom", "sem", "bob" }, "bob", 1, new string[] { "tom", "sem", "bob" }, "sem", 7)]
        [InlineData(6, new string[] { "", "", "" }, "", 0, new string[] { "", "", "", "", "" }, "", 9)]
        [InlineData(3, new string[] { null, null }, null, 0, new string[] { null, null }, null, 5)]
        [InlineData(8, new string[] { "1", "2", "3", "4", "5" }, "4", 2, new string[] { "6", "7", "8", "9", "10" }, "8", 11)]
        [InlineData(10, new string[] { "q", "w", "e", "r", "t", "y" }, "t", 2, new string[] { "a", "s", "d", "f", "g", "h" }, "d", 13)]
        public void InsertRangeInStart_Valid_StringByCountAndIndex(int indexItem1, string[] items1, string expectedItem1, int indexItem2, string[] items2, string expectedItem2, int expectedCount)
        {
            // Arrange
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertRangeInStart(items1);
            _collectionString.InsertRangeInStart(items2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[indexItem1].Should().Be(expectedItem1);
            _collectionString[indexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(new string[] { "tom", "sem", "bob" }, new string[] { "alex", "sem", "bob" })]
        [InlineData(new string[] { "", "", "" }, new string[] { "", "", "", "", "" })]
        [InlineData(new string[] { null, null }, new string[] { null, null })]
        [InlineData(new string[] { "1", "2", "3", "4", "5" }, new string[] { "6", "7", "8", "9", "10" })]
        [InlineData(new string[] { "q", "w", "e", "r", "t", "y" }, new string[] { "a", "s", "d", "f", "g", "h" })]
        public void InsertRangeInStart_Valid_StringByEquals(string[] items1, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add("Alex");
            expectedСollection.InsertRangeInStart(items1);
            expectedСollection.InsertRangeInStart(items2);
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertRangeInStart(items1);
            _collectionString.InsertRangeInStart(items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRangeInStart.GetDataForInsertRangeInStartValidClassByEquals), MemberType = typeof(MyListSourceDataForInsertRangeInStart))]
        public void InsertRangeInStart_Valid_ClassByEquals(Employee[,] values, MyList<Employee> expectedСollection)
        {
            _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });

            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.InsertRangeInStart(myArray);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
