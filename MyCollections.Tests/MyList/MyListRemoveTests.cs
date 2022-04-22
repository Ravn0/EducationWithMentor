using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListRemoveTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListRemoveTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 20, 99)]
        [InlineData(10, 50, 50, 90)]
        [InlineData(50, 49, 49, 50)]
        [InlineData(99, 0, 0, 1)]
        public void Remove_Valid_Int_By_Count_And_Index_1(int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionInt.Remove();
            }

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void Remove_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                collection.Remove();
            }

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void Remove_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int qtyRemoves)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionInt.Remove();
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(1, 10, "Mason", 20, "Jack", 99)]
        [InlineData(10, 12, "Ethan", 25, "Joseph", 90)]
        [InlineData(50, 15, "Logan", 40, "Anthony", 50)]
        [InlineData(98, 0, "Liam", 1, "Noah", 2)]
        public void Remove_Valid_String_By_Count_And_Index(int qtyRemoves, int expectedindexItem1, string expectedItem1,
            int expectedindexItem2, string expectedItem2, int expectedCount)
        {
            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionString.Remove();
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
        [InlineData(150)]
        public void Remove_Valid_String_By_Equals(int qtyRemoves)
        {
            // Arrange
            var expectedСollection = new MyList<string>(ArrayInitializationString());
            for (int i = 0; i < qtyRemoves; i++)
            {
                expectedСollection.Remove();
            }

            // Act
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionString.Remove();
            }

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void Remove_Valid_Class_By_Equals(int qtyRemoves, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionClass.Remove();
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 21, 99)]
        [InlineData(10, 50, 60, 90)]
        [InlineData(50, 49, 99, 50)]
        [InlineData(99, 0, 99, 1)]
        public void RemoveStart_Valid_Int_By_Count_And_Index_1(int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int qtyRemoves, int expectedIndex, int expectedValue, int expectedCount)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveStartValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveStart_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int qtyRemoves)
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
        public void RemoveStart_Valid_String_By_Count_And_Index(int qtyRemoves, int expectedindexItem1, string expectedItem1,
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
        public void RemoveStart_Valid_String_By_Equals(int qtyRemoves)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveStartValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveStart_Valid_Class_By_Equals(int qtyRemoves, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < qtyRemoves; i++)
            {
                _collectionClass.RemoveStart();
            }

            _collectionClass.Should().Be(expectedСollection);
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAtValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveAt_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveAt(index);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAtValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAtValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveAt_Valid_Class_By_Equals(int[] indexes, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < indexes.Length; i++)
            {
                _collectionClass.RemoveAt(indexes[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(0, 10, 10, 100)]
        [InlineData(1, 20, 20, 99)]
        [InlineData(10, 89, 89, 90)]
        [InlineData(50, 49, 49, 50)]
        [InlineData(99, 0, 0, 1)]
        public void RemoveRange_Valid_Int_By_Count_And_Index_1(int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveRange(count);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRange_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRange(count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRange_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int count)
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
        public void RemoveRange_Valid_String_By_Count_And_Index(int count, int expectedindexItem1, string expectedItem1,
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
        public void RemoveRange_Valid_String_By_Equals(int count)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRange_Valid_Class_By_Equals(int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRange(count);

            _collectionClass.Should().Be(expectedСollection);
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRangeStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRangeStart(count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeStartValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeStartValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRangeStart_Valid_Class_By_Equals(int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRangeStart(count);

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(10, 0, 10, 10, 100)]
        [InlineData(50, 1, 20, 20, 99)]
        [InlineData(10, 10, 89, 99, 90)]
        [InlineData(70, 20, 39, 39, 80)]
        [InlineData(90, 99, 2, 2, 90)]
        public void RemoveRangeAt_Valid_Int_By_Count_And_Index_1(int index, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            _collectionInt.RemoveRangeAt(index, count);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeAtValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRangeAt_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int count, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveRangeAt(index, count);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeAtValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRangeAt_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int index, int count)
        {
            // Act
            _collectionInt.RemoveRangeAt(index, count);

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(10, 0, 10, "Mason", 40, "Anthony", 100)]
        [InlineData(15, 1, 10, "Mason", 20, "Owen", 99)]
        [InlineData(14, 10, 12, "Ethan", 25, "Leo", 90)]
        [InlineData(5, 50, 15, "Colton", 49, "Silas", 50)]
        [InlineData(90, 98, 0, "Liam", 89, "Everett", 90)]
        public void RemoveRangeAt_Valid_String_By_Count_And_Index(int index, int count, int expectedindexItem1, string expectedItem1,
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
        public void RemoveRangeAt_Valid_String_By_Equals(int index, int count)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveRangeAtValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveRangeAt_Valid_Class_By_Equals(int index, int count, MyList<Employee> expectedСollection)
        {
            _collectionClass.RemoveRangeAt(index, count);

            _collectionClass.Should().Be(expectedСollection);
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveFirstValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveFirst_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Act
            collection.RemoveFirst(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveFirstValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveFirstValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
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

        [Theory]
        [InlineData(0, 4, 3, 4, 13)]
        [InlineData(5, 1, 5, 4, 16)]
        [InlineData(7, 4, 8, 8, 13)]
        [InlineData(9, 2, 13, 0, 15)]
        [InlineData(99, 0, 0, 0, 17)]
        public void RemoveAll_Valid_Int_By_Count_And_Index_1(int value, int expectedCountRemoves, int expectedIndex, int expectedValue, int expectedCount)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAllValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveAll_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCountRemoves,
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAllValidIntByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveAll_Valid_Int_By_Equals(IMyCollection<int> expectedСollection, int value, int expectedCountRemoves)
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
        public void RemoveAll_Valid_String_By_Count_And_Index(string value, int expectedCountRemoves, int expectedindexItem1, string expectedItem1,
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
        public void RemoveAll_Valid_String_By_Equals(string value, int expectedCountRemoves)
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
        [MemberData(nameof(MyListSourceDataForRemove.GetDataForRemoveAllValidClassByEquals), MemberType = typeof(MyListSourceDataForRemove))]
        public void RemoveAll_Valid_Class_By_Equals(Employee value, int expectedCountRemoves, MyList<Employee> expectedСollection)
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
