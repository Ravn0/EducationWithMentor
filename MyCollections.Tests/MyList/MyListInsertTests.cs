using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListInsertTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListInsertTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        [InlineData(10, 4)]
        [InlineData(100, 5)]
        [InlineData(1000, 6)]
        [InlineData(10000, 7)]
        public void Insert_Valid_IntByCountAndIndex1(int value, int index)
        {
            // Arrange
            var expectedCount = 11;
            for (int i = 0; i < 10; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            _collectionInt.Insert(index, value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[index].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsert.GetDataForInsertValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForInsert))]
        public void Insert_Valid_IntByCountAndIndex2(IMyCollection<int> collection, int index, int value, int expectedCount)
        {
            // Act
            collection.Insert(index, value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[index].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsert.GetDataForInsertValidIntByEquals), MemberType = typeof(MyListSourceDataForInsert))]
        public void Insert_Valid_IntByEquals(int[] indexes, int[] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            for (int i = 0; i < values.Length; i++)
            {
                _collectionInt.Insert(indexes[i], values[i]);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(102, 20)]
        [InlineData(1000, 30)]
        public void Insert_Invalid_Int(int index, int value)
        {
            // Act
            Action act = () => _collectionInt.Insert(index, value);

            // Assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Theory]
        [InlineData(8, "tom", 34, "sem")]
        [InlineData(11, "", 65, "")]
        [InlineData(12, null, 17, null)]
        [InlineData(48, "1", 87, "2")]
        [InlineData(56, "s", 59, "a")]
        public void Insert_Valid_StringByCountAndIndex(int indexItem1, string item1, int indexItem2, string item2)
        {
            // Arrange
            var expectedCount = 102;
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }


            // Act
            _collectionString.Insert(indexItem1, item1);
            _collectionString.Insert(indexItem2, item2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[indexItem1].Should().Be(item1);
            _collectionString[indexItem2].Should().Be(item2);
        }

        [Theory]
        [InlineData(8, "tom", 34, "sem")]
        [InlineData(11, "", 65, "")]
        [InlineData(12, null, 1, null)]
        [InlineData(48, "1", 87, "2")]
        [InlineData(56, "s", 13, "a")]
        public void Insert_Valid_StringByEquals(int indexItem1, string item1, int indexItem2, string item2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            for (int i = 0; i < 100; i++)
            {
                expectedСollection.Add("Alex");
            }

            expectedСollection.Insert(indexItem1, item1);
            expectedСollection.Insert(indexItem2, item2);
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }

            // Act
            _collectionString.Insert(indexItem1, item1);
            _collectionString.Insert(indexItem2, item2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForInsert.GetDataForInsertValidClassByEquals), MemberType = typeof(MyListSourceDataForInsert))]
        public void Insert_Valid_ClassByEquals(int[] indexes, Employee[] values, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < 100; i++)
            {
                _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < values.Length; i++)
            {
                _collectionClass.Insert(indexes[i], values[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}
