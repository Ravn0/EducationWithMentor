using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListInsertInStartTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListInsertInStartTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        public void InsertInStart_Valid_IntByCountAndIndex1(int value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 2;
            _collectionInt.Add(0);

            // Act
            _collectionInt.InsertInStart(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertInStart.GetDataForInsertInStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForInsertInStart))]
        public void InsertInStart_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.InsertInStart(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertInStart.GetDataForInsertInStartValidIntByEquals), MemberType = typeof(MyListSourceDataForInsertInStart))]
        public void InsertInStart_Valid_IntByEquals(int[] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            for (int i = 0; i < values.Length; i++)
            {
                _collectionInt.InsertInStart(values[i]);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "2")]
        [InlineData("s", "a")]
        public void InsertInStart_Valid_StringByCountAndIndex(string item1, string item2)
        {
            // Arrange
            var expectedindexItem1 = 1;
            var expectedindexItem2 = 0;
            var expectedCount = 3;
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertInStart(item1);
            _collectionString.InsertInStart(item2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(item1);
            _collectionString[expectedindexItem2].Should().Be(item2);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void InsertInStart_Valid_StringByEquals(string item1, string item2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add("Alex");
            expectedСollection.InsertInStart(item1);
            expectedСollection.InsertInStart(item2);
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertInStart(item1);
            _collectionString.InsertInStart(item2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsertInStart.GetDataForInsertInStartValidClassByEquals), MemberType = typeof(MyListSourceDataForInsertInStart))]
        public void InsertInStart_Valid_ClassByEquals(Employee[] values, MyList<Employee> expectedСollection)
        {
            _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });

            for (int i = 0; i < values.Length; i++)
            {
                _collectionClass.InsertInStart(values[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
