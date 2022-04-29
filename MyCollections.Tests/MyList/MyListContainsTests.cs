using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListContainsTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListContainsTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(10, true)]
        [InlineData(50, true)]
        [InlineData(99, true)]
        [InlineData(100, false)]
        [InlineData(1000, false)]
        public void Contains_Valid_Int1(int value, bool expectedResult)
        {
            // Act
            var result = _collectionInt.Contains(value);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForContains.GetDataForContainsValidInt), MemberType = typeof(MyListSourceDataForContains))]
        public void Contains_Valid_Int2(IMyCollection<int> collection, int value, bool expectedResult)
        {
            // Act
            var result = collection.Contains(value);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("Mason", true, "Anthony", true)]
        [InlineData("Mason", true, "Jack", true)]
        [InlineData("Ethan", true, "Joseph", true)]
        [InlineData("Logan", true, "Anthony", true)]
        [InlineData("Liam", true, "Noah", true)]
        [InlineData("Liam", true, "Alex", false)]
        [InlineData("Sam", false, "Jack", true)]
        [InlineData("Ban", false, "Alex", false)]
        [InlineData("Liam", true, null, false)]
        [InlineData(null, false, "Jack", true)]
        [InlineData(null, false, null, false)]
        public void Contains_Valid_String1(string value1, bool expectedResult1, string value2, bool expectedResult2)
        {
            // Act
            var result1 = _collectionString.Contains(value1);
            var result2 = _collectionString.Contains(value2);

            // Assert
            result1.Should().Be(expectedResult1);
            result2.Should().Be(expectedResult2);
        }

        [Theory]
        [InlineData("Mason", true)]
        [InlineData("Ethan", true)]
        [InlineData("Logan", true)]
        [InlineData("Liam", true)]
        [InlineData("Sam", false)]
        [InlineData("Ban", false)]
        [InlineData(null, true)]
        public void Contains_Valid_String2(string value, bool expectedResult)
        {
            // Arrange
            _collectionString = new MyList<string>(new string[] { "Liam", "Logan", null, "Mason", null, "Ethan" });

            // Act
            var result = _collectionString.Contains(value);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForContains.GetDataForContainsValidClass), MemberType = typeof(MyListSourceDataForContains))]
        public void Contains_Valid_Class(Employee value, bool expectedResult)
        {
            // Act
            var result = _collectionClass.Contains(value);

            // Assert
            result.Should().Be(expectedResult);
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
