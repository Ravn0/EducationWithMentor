using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListInsertRangeTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListInsertRangeTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 1, 12, 2, 10)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 3, 14, 4, 2)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 5, 17, 9, -5)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 6, 14, 9, 1000)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 7, 20, 7, 0)]
        [InlineData(new int[] { -1, 0, 1 }, 9, 13, 11, 1)]
        public void InsertRange_Valid_Int_By_Count_And_Index_1(int[] value, int index, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Arrange
            for (int i = 0; i < 10; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            _collectionInt.InsertRange(index, value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRange.GetDataForInsertRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForInsertRange))]
        public void InsertRange_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int[] value, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.InsertRange(index, value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRange.GetDataForInsertRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForInsertRange))]
        public void InsertRange_Valid_Int_By_Equals(int[] indexes, int[,] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.InsertRange(indexes[i], myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(2, new string[] { "tom", "sem", "bob" }, 4, "bob", 54, new string[] { "tom", "sem", "bob" }, 55, "sem", 106)]
        [InlineData(1, new string[] { "", "", "" }, 2, "", 65, new string[] { "", "", "", "", "" }, 67, "", 108)]
        [InlineData(10, new string[] { null, null }, 11, null, 96, new string[] { null, null }, 96, null, 104)]
        [InlineData(3, new string[] { "1", "2", "3", "4", "5" }, 6, "4", 89, new string[] { "6", "7", "8", "9", "10" }, 91, "8", 110)]
        [InlineData(24, new string[] { "q", "w", "e", "r", "t", "y" }, 28, "t", 105, new string[] { "a", "s", "d", "f", "g", "h" }, 107, "d", 112)]
        public void InsertRange_Valid_String_By_Count_And_Index(int indexItem1, string[] items1, int expectedIndexItem1, string expectedItem1, int indexItem2, string[] items2, int expectedIndexItem2, string expectedItem2, int expectedCount)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }


            // Act
            _collectionString.InsertRange(indexItem1, items1);
            _collectionString.InsertRange(indexItem2, items2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedIndexItem1].Should().Be(expectedItem1);
            _collectionString[expectedIndexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(8, new string[] { "tom", "sem", "bob" }, 22, new string[] { "alex", "sem", "bob" })]
        [InlineData(5, new string[] { "", "", "" }, 55, new string[] { "", "", "", "", "" })]
        [InlineData(7, new string[] { null, null }, 76, new string[] { null, null })]
        [InlineData(56, new string[] { "1", "2", "3", "4", "5" }, 90, new string[] { "6", "7", "8", "9", "10" })]
        [InlineData(43, new string[] { "q", "w", "e", "r", "t", "y" }, 99, new string[] { "a", "s", "d", "f", "g", "h" })]
        public void InsertRange_Valid_String_By_Equals(int indexItem1, string[] items1, int indexItem2, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            for (int i = 0; i < 100; i++)
            {
                expectedСollection.Add("Alex");
            }

            expectedСollection.InsertRange(indexItem1, items1);
            expectedСollection.InsertRange(indexItem2, items2);
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }

            // Act
            _collectionString.InsertRange(indexItem1, items1);
            _collectionString.InsertRange(indexItem2, items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertRange.GetDataForInsertRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForInsertRange))]
        public void InsertRange_Valid_Class_By_Equals(int[] indexes, Employee[,] values, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < 100; i++)
            {
                _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });
            }

            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.InsertRange(indexes[i], myArray);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
