using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListIndexOfTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListIndexOfTests()
        {
            _collectionInt = new MyList<int>(ArrayInitializationInt());
            _collectionString = new MyList<string>(ArrayInitializationString());
            _collectionClass = new MyList<Employee>(ArrayInitializationClass());
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(50, 50)]
        [InlineData(99, 99)]
        [InlineData(100, -1)]
        [InlineData(1000, -1)]
        public void IndexOf_Valid_Int1(int value, int expectedResult)
        {
            // Act
            var result = _collectionInt.IndexOf(value);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForIndexOf.GetDataForIndexOfValidInt), MemberType = typeof(MyListSourceDataForIndexOf))]
        public void IndexOf_Valid_Int2(IMyCollection<int> collection, int value, int expectedResult)
        {
            // Act
            var result = collection.IndexOf(value);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("Mason", 10, "Anthony", 40)]
        [InlineData("Mason", 10, "Jack", 20)]
        [InlineData("Ethan", 12, "Joseph", 25)]
        [InlineData("Logan", 15, "Anthony", 40)]
        [InlineData("Liam", 0, "Noah", 1)]
        [InlineData("Liam", 0, "Alex", -1)]
        [InlineData("Sam", -1, "Jack", 20)]
        [InlineData("Ban", -1, "Alex", -1)]
        [InlineData("Liam", 0, null, -1)]
        [InlineData(null, -1, "Jack", 20)]
        [InlineData(null, -1, null, -1)]
        public void IndexOf_Valid_String(string value1, int expectedResult1, string value2, int expectedResult2)
        {
            // Act
            var result1 = _collectionString.IndexOf(value1);
            var result2 = _collectionString.IndexOf(value2);

            // Assert
            result1.Should().Be(expectedResult1);
            result2.Should().Be(expectedResult2);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForIndexOf.GetDataForIndexOfValidClass), MemberType = typeof(MyListSourceDataForIndexOf))]
        public void IndexOf_Valid_Class(Employee value, int expectedResult)
        {
            // Act
            var result = _collectionClass.IndexOf(value);

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
