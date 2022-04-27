using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListAddTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListAddTests()
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
        public void Add_Valid_Int_By_Count_And_Index_1(int value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 1;

            // Act
            _collectionInt.Add(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAdd.GetDataForAddValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAdd))]
        public void Add_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.Add(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAdd.GetDataForAddValidIntByEquals), MemberType = typeof(MyListSourceDataForAdd))]
        public void Add_Valid_Int_By_Equals(int[] values, IMyCollection<int> expectedСollection)
        {
            // Act
            for (int i = 0; i < values.Length; i++)
            {
                _collectionInt.Add(values[i]);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void Add_Valid_String_By_Count_And_Index(string item1, string item2)
        {
            // Arrange
            var expectedIndexItem1 = 0;
            var expectedIndexItem2 = 1;
            var expectedCount = 2;

            // Act
            _collectionString.Add(item1);
            _collectionString.Add(item2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedIndexItem1].Should().Be(item1);
            _collectionString[expectedIndexItem2].Should().Be(item2);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void Add_Valid_String_By_Equals(string item1, string item2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add(item1);
            expectedСollection.Add(item2);

            // Act
            _collectionString.Add(item1);
            _collectionString.Add(item2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAdd.GetDataForAddValidClassByEquals), MemberType = typeof(MyListSourceDataForAdd))]
        public void Add_Valid_Class_By_Equals(Employee[] values, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < values.Length; i++)
            {
                _collectionClass.Add(values[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
