using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveStartTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveStartTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 21, 99)]
        [InlineData(10, 50, 60, 90)]
        [InlineData(50, 49, 99, 50)]
        [InlineData(99, 0, 99, 1)]
        public void RemoveStart_Valid_IntByCountAndIndex1(int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionInt.RemoveStart();
            }

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveStart.GetDataForRemoveStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveStart))]
        public void RemoveStart_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.RemoveStart();
            }

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveStart.GetDataForRemoveStartValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveStart))]
        public void RemoveStart_Valid_IntByEquals(IMyCollection<int> expectedСollection, int qtyRemoves)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionInt.RemoveStart();
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(1, 10, "Michael", 20, "Owen", 99)]
        [InlineData(10, 12, "Theodore", 25, "Leo", 90)]
        [InlineData(50, 15, "Colton", 40, "Brooks", 50)]
        [InlineData(98, 0, "Kayden", 1, "Silas", 2)]
        public void RemoveStart_Valid_StringByCountAndIndex(int qtyRemoves, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionString.RemoveStart();
            }

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
        [InlineData(100)]
        public void RemoveStart_Valid_StringByEquals(int qtyRemoves)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            for (int i = 0; i < qtyRemoves; i++)
            {
                expectedСollection.RemoveStart();
            }

            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionString.RemoveStart();
            }

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveStart.GetDataForRemoveStartValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveStart))]
        public void RemoveStart_Valid_ClassByEquals(int qtyRemoves, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionClass.RemoveStart();
            }

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
