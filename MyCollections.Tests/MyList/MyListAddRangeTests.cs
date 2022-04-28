using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListAddRangeTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListAddRangeTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 2, 10, 1)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 4, 4, 3)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 7, -5, 4)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 4, 100, 2)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 10, 0, 0)]
        [InlineData(new int[] { -1, 0, 1 }, 3, 1, 2)]
        public void AddRange_Valid_IntByCountAndIndex1(int[] values, int expectedCount, int expectedValue, int expectedIndex)
        {
            _collectionInt.AddRange(values);

            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddRange.GetDataForAddRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddRange))]
        public void AddRange_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int[] values, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.AddRange(values);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddRange.GetDataForAddRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForAddRange))]
        public void AddRange_Valid_IntByEquals(int[,] values, IMyCollection<int> expectedСollection)
        {
            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.AddRange(myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(2, new string[] { "tom", "sem", "bob" }, "bob", 4, new string[] { "tom", "sem", "bob" }, "sem", 6)]
        [InlineData(1, new string[] { "", "", "" }, "", 6, new string[] { "", "", "", "", "" }, "", 8)]
        [InlineData(0, new string[] { null, null }, null, 2, new string[] { null, null }, null, 4)]
        [InlineData(3, new string[] { "1", "2", "3", "4", "5" }, "4", 7, new string[] { "6", "7", "8", "9", "10" }, "8", 10)]
        [InlineData(4, new string[] { "q", "w", "e", "r", "t", "y" }, "t", 8, new string[] { "a", "s", "d", "f", "g", "h" }, "d", 12)]
        public void AddRange_Valid_StringByCountAndIndex(int indexItem1, string[] items1, string expectedItem1, int indexItem2, string[] items2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.AddRange(items1);
            _collectionString.AddRange(items2);

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
        public void AddRange_Valid_StringByEquals(string[] items1, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.AddRange(items1);
            expectedСollection.AddRange(items2);

            // Act
            _collectionString.AddRange(items1);
            _collectionString.AddRange(items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddRange.GetDataForAddRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForAddRange))]
        public void AddRange_Valid_ClassByEquals(Employee[,] values, MyList<Employee> expectedСollection)
        {
            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.AddRange(myArray);
            }


            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
