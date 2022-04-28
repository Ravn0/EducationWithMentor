using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveRangeTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveRangeTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 20, 99)]
        [InlineData(10, 89, 89, 90)]
        [InlineData(50, 49, 49, 50)]
        [InlineData(99, 0, 0, 1)]
        public void RemoveRange_Valid_IntByCountAndIndex1(int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveRange(count);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRange.GetDataForRemoveRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveRange))]
        public void RemoveRange_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRange(count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRange.GetDataForRemoveRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveRange))]
        public void RemoveRange_Valid_IntByEquals(IMyCollection<int> expectedСollection, int count)
        {
            // Act
            _collectionInt.RemoveRange(count);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(1, 10, "Mason", 20, "Jack", 99)]
        [InlineData(10, 12, "Ethan", 25, "Joseph", 90)]
        [InlineData(50, 15, "Logan", 49, "Josiah", 50)]
        [InlineData(98, 0, "Liam", 1, "Noah", 2)]
        public void RemoveRange_Valid_StringByCountAndIndex(int count, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.RemoveRange(count);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(expectedItem1);
            _collectionString[expectedindexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(20)]
        [InlineData(60)]
        [InlineData(99)]
        [InlineData(100)]
        [InlineData(150)]
        public void RemoveRange_Valid_StringByEquals(int count)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            expectedСollection.RemoveRange(count);

            // Act
            _collectionString.RemoveRange(count);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRange.GetDataForRemoveRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveRange))]
        public void RemoveRange_Valid_ClassByEquals(int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRange(count);

            _collectionClass.Should().Be(expectedСollection);
        }

        private int[] ArrayInitializationInt()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        private string[] ArrayInitializationString()
        {
            var array = new string[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ((Names)i).ToString();
            }

            return array;
        }

        private Employee[] ArrayInitializationClass()
        {
            var array = new Employee[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Employee { Name = ((Names)i).ToString(), Age = i };
            }

            return array;
        }
    }
}
