using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveRangeAtTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveRangeAtTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(10, 0, 10, 10, 100)]
        [InlineData(50, 1, 20, 20, 99)]
        [InlineData(10, 10, 89, 99, 90)]
        [InlineData(70, 20, 39, 39, 80)]
        [InlineData(90, 99, 2, 2, 90)]
        public void RemoveRangeAt_Valid_IntByCountAndIndex1(int index, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveRangeAt(index, count);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeAt.GetDataForRemoveRangeAtValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveRangeAt))]
        public void RemoveRangeAt_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int index, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRangeAt(index, count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeAt.GetDataForRemoveRangeAtValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveRangeAt))]
        public void RemoveRangeAt_Valid_IntByEquals(IMyCollection<int> expectedСollection, int index, int count)
        {
            // Act
            _collectionInt.RemoveRangeAt(index, count);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(100, 10)]
        [InlineData(102, 20)]
        [InlineData(1000, 30)]
        public void RemoveRangeAt_Invalid_Int(int index, int count)
        {
            // Act
            Action act = () => _collectionInt.RemoveRangeAt(index, count);

            // Assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Theory]
        [InlineData(10, 0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(15, 1, 10, "Mason", 20, "Owen", 99)]
        [InlineData(14, 10, 12, "Ethan", 25, "Leo", 90)]
        [InlineData(5, 50, 15, "Colton", 49, "Silas", 50)]
        [InlineData(90, 98, 0, "Liam", 89, "Everett", 90)]
        public void RemoveRangeAt_Valid_StringByCountAndIndex(int index, int count, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.RemoveRangeAt(index, count);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(expectedItem1);
            _collectionString[expectedindexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(50, 0)]
        [InlineData(60, 2)]
        [InlineData(10, 20)]
        [InlineData(5, 60)]
        [InlineData(50, 99)]
        [InlineData(10, 100)]
        [InlineData(68, 150)]
        public void RemoveRangeAt_Valid_StringByEquals(int index, int count)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            expectedСollection.RemoveRangeAt(index, count);

            // Act
            _collectionString.RemoveRangeAt(index, count);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeAt.GetDataForRemoveRangeAtValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveRangeAt))]
        public void RemoveRangeAt_Valid_ClassByEquals(int index, int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRangeAt(index, count);

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
