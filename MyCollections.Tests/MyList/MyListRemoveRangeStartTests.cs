using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveRangeStartTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveRangeStartTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 21, 99)]
        [InlineData(10, 89, 99, 90)]
        [InlineData(50, 39, 89, 50)]
        [InlineData(99, 0, 99, 1)]
        public void RemoveRangeStart_Valid_Int_By_Count_And_Index_1(int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveRangeStart(count);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeStart.GetDataForRemoveRangeStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveRangeStart))]
        public void RemoveRangeStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRangeStart(count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeStart.GetDataForRemoveRangeStartValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveRangeStart))]
        public void RemoveRangeStart_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int count)
        {
            // Act
            _collectionInt.RemoveRangeStart(count);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(1, 10, "Michael", 20, "Owen", 99)]
        [InlineData(10, 12, "Theodore", 25, "Leo", 90)]
        [InlineData(50, 15, "Colton", 49, "Silas", 50)]
        [InlineData(98, 0, "Kayden", 1, "Silas", 2)]
        public void RemoveRangeStart_Valid_String_By_Count_And_Index(int count, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.RemoveRangeStart(count);

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
        public void RemoveRangeStart_Valid_String_By_Equals(int count)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            expectedСollection.RemoveRangeStart(count);

            // Act
            _collectionString.RemoveRangeStart(count);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveRangeStart.GetDataForRemoveRangeStartValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveRangeStart))]
        public void RemoveRangeStart_Valid_Class_By_Equals(int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRangeStart(count);

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
