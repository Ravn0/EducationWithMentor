using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveFirstTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveFirstTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(0, 4, 4, 14)]
        [InlineData(5, 5, 4, 14)]
        [InlineData(7, 11, 8, 14)]
        [InlineData(9, 13, 9, 14)]
        [InlineData(99, 0, 0, 15)]
        public void RemoveFirst_Valid_Int_By_Count_And_Index_1(int value, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Arrange
            _collectionInt = new MyList<int>(new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });

            // Act
            _collectionInt.RemoveFirst(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveFirst.GetDataForRemoveFirstValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemoveFirst))]
        public void RemoveFirst_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveFirst(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveFirst.GetDataForRemoveFirstValidIntByEquals), MemberType = typeof(MyListSourceDataForRemoveFirst))]
        public void RemoveFirst_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int value)
        {
            // Arrange
            _collectionInt = new MyList<int>(new int[] { -2, -2, -1, 0, 0, 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 8, 9, 9 });

            // Act
            _collectionInt.RemoveFirst(value);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData("alex", 0, "tom", 8, "jack", 11)]
        [InlineData("tom", 0, "alex", 8, "jack", 11)]
        [InlineData("igor", 1, "tom", 4, "sam", 11)]
        [InlineData("sam", 1, "tom", 5, "sam", 11)]
        [InlineData("Liam", 0, "alex", 9, "jack", 12)]
        [InlineData(null, 0, "alex", 9, "jack", 11)]
        public void RemoveFirst_Valid_String_By_Count_And_Index(string value, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Arrange
            _collectionString = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });

            // Act
            _collectionString.RemoveFirst(value);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(expectedItem1);
            _collectionString[expectedindexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData("alex")]
        [InlineData("tom")]
        [InlineData("igor")]
        [InlineData("sam")]
        [InlineData("jack")]
        [InlineData("Liam")]
        [InlineData(null)]
        public void RemoveFirst_Valid_String_By_Equals(string value)
        {
            // Arrange
            var expectedСollection = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });
            _collectionString = new MyList<string>(new string[] { "alex", "tom", "tom", "ban", "igor", "sam", "sam", "sam", "oliver", "jack", null, null });
            expectedСollection.RemoveFirst(value);

            // Act
            _collectionString.RemoveFirst(value);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemoveFirst.GetDataForRemoveFirstValidClassByEquals), MemberType = typeof(MyListSourceDataForRemoveFirst))]
        public void RemoveFirst_Valid_Class_By_Equals(Employee value, MyList<Employee> expectedСollection)
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

            _collectionClass.RemoveFirst(value);

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
