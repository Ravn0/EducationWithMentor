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
