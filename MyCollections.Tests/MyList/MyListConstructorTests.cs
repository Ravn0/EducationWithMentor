using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListConstructorTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;

        public MyListConstructorTests()
        {

        }

        [Fact]
        public void Constructor_Valid_Int0()
        {
            // Arrange
            var expectedCount = 0;

            // Act
            _collectionInt = new MyList<int>();

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        public void Constructor_Valid_Int1(int value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 1;

            // Act
            _collectionInt = new MyList<int>(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(value);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 0, 10)]
        [InlineData(new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 }, 3, -2, 11)]
        [InlineData(new int[] { 0, 0, 0 }, 2, 0, 3)]
        [InlineData(new int[] { 1, 10, 100, 1000, 10000 }, 3, 1000, 5)]
        public void Constructor_Valid_Int2(int[] value, int expectedIndex, int expectedValue, int expectedCount)
        {

            // Act
            _collectionInt = new MyList<int>(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("tom")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("1")]
        [InlineData("s")]
        public void Constructor_Valid_String1(string value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 1;

            // Act
            _collectionString = new MyList<string>(value);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedIndex].Should().Be(value);
        }

        [Theory]
        [InlineData(new string[] { "tom", "sam", "alex" }, 0, "tom", 3)]
        [InlineData(new string[] { "", "" }, 1, "", 2)]
        [InlineData(new string[] { null, null, null, null }, 3, null, 4)]
        [InlineData(new string[] { "1", "2", "3", "4", "5" }, 2, "3", 5)]
        [InlineData(new string[] { "a", "q", "w", "e", "s", "f" }, 5, "f", 6)]
        public void Constructor_Valid_String2(string[] value, int expectedIndex, string expectedValue, int expectedCount)
        {

            // Act
            _collectionString = new MyList<string>(value);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedIndex].Should().Be(expectedValue);
        }
    }
}
