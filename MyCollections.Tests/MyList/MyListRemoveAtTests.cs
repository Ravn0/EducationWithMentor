using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveAtTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveAtTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 10, 11, 99)]
        [InlineData(1, 20, 21, 99)]
        [InlineData(10, 50, 51, 99)]
        [InlineData(50, 1, 1, 99)]
        [InlineData(99, 50, 50, 99)]
        public void RemoveAt_Valid_Int_By_Count_And_Index_1(int index, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveAt(index);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(0, 10, 11, 99)]
        [InlineData(1, 20, 21, 99)]
        [InlineData(10, 50, 51, 99)]
        [InlineData(50, 1, 1, 99)]
        [InlineData(99, 50, 50, 99)]
        public void RemoveAt_Invalid_Int(int index, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveAt(index);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAt.GetDataForRemoveAtValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveAt))]
        public void RemoveAt_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveAt(index);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAt.GetDataForRemoveAtValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveAt))]
        public void RemoveAt_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int index)
        {
            // Act
            _collectionInt.RemoveAt(index);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(50, 10, "Mason", 40, "Anthony", 99)]
        [InlineData(1, 10, "Michael", 20, "Owen", 99)]
        [InlineData(10, 12, "Daniel", 25, "John", 99)]
        [InlineData(50, 15, "Logan", 60, "Christian", 99)]
        [InlineData(98, 0, "Liam", 98, "Silas", 99)]
        public void RemoveAt_Valid_String_By_Count_And_Index(int index, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.RemoveAt(index);

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
        public void RemoveAt_Valid_String_By_Equals(int index)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            expectedСollection.RemoveAt(index);

            // Act
            _collectionString.RemoveAt(index);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAt.GetDataForRemoveAtValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveAt))]
        public void RemoveAt_Valid_Class_By_Equals(int[] indexes, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < indexes.Length; i++)
            {
                _collectionClass.RemoveAt(indexes[i]);
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
