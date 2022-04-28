using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveAllTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveAllTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(0, 4, 3, 4, 13)]
        [InlineData(5, 1, 5, 4, 16)]
        [InlineData(7, 4, 8, 8, 13)]
        [InlineData(9, 2, 13, 0, 15)]
        [InlineData(99, 0, 0, 0, 17)]
        public void RemoveAll_Valid_IntByCountAndIndex1(int value, int expectedCountRemoves, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Arrange
            _collectionInt = new MyList<int>(new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 0, 0 });

            // Act
            var countRemoves = _collectionInt.RemoveAll(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
            countRemoves.Should().Be(expectedCountRemoves);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAll.GetDataForRemoveAllValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveAll))]
        public void RemoveAll_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int value, int expectedCountRemoves,
            int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            var countRemoves = collection.RemoveAll(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
            countRemoves.Should().Be(expectedCountRemoves);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAll.GetDataForRemoveAllValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveAll))]
        public void RemoveAll_Valid_IntByEquals(IMyCollection<int> expectedСollection, int value, int expectedCountRemoves)
        {
            // Arrange
            _collectionInt = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9, 7, 7, -2, 1, 1, 5 });

            // Act
            var countRemoves = _collectionInt.RemoveAll(value);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
            countRemoves.Should().Be(expectedCountRemoves);
        }

        [Theory]
        [InlineData("alex", 1, 0, "tom", 8, "jack", 11)]
        [InlineData("tom", 2, 0, "alex", 7, "jack", 10)]
        [InlineData("igor", 1, 1, "tom", 4, "sam", 11)]
        [InlineData("sam", 3, 1, "tom", 5, "oliver", 9)]
        [InlineData("Liam", 0, 0, "alex", 9, "jack", 12)]
        [InlineData(null, 2, 0, "alex", 9, "jack", 10)]
        public void RemoveAll_Valid_StringByCountAndIndex(string value, int expectedCountRemoves, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Arrange
            _collectionString = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });

            // Act
            var countRemoves = _collectionString.RemoveAll(value);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(expectedItem1);
            _collectionString[expectedindexItem2].Should().Be(expectedItem2);
            countRemoves.Should().Be(expectedCountRemoves);
        }

        [Theory]
        [InlineData("alex", 1)]
        [InlineData("tom", 2)]
        [InlineData("igor", 1)]
        [InlineData("sam", 3)]
        [InlineData("jack", 1)]
        [InlineData("Liam", 0)]
        [InlineData(null, 2)]
        public void RemoveAll_Valid_StringByEquals(string value, int expectedCountRemoves)
        {
            // Arrange
            var expectedСollection = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });
            _collectionString = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });
            expectedСollection.RemoveAll(value);

            // Act
            var countRemoves = _collectionString.RemoveAll(value);

            // Assert
            _collectionString.Should().Be(expectedСollection);
            countRemoves.Should().Be(expectedCountRemoves);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveAll.GetDataForRemoveAllValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveAll))]
        public void RemoveAll_Valid_ClassByEquals(Employee value, int expectedCountRemoves, MyList<Employee> expectedСollection)
        {
            _collectionClass = new MyList<Employee>(new Employee[] {
            new Employee { Name = "alex", Age = 23 },
            new Employee { Name = "tom", Age = 10 },
            new Employee { Name = "tom", Age = 15 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "ban", Age = 16 },
            new Employee { Name = "sam", Age = 45 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "jack", Age = 12 },
            new Employee { Name = "oliver", Age = 24 },});

            var countRemoves = _collectionClass.RemoveAll(value);

            _collectionClass.Should().Be(expectedСollection);
            countRemoves.Should().Be(expectedCountRemoves);
        }
    }
}
