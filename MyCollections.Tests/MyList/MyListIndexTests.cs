using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListIndexTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListIndexTests()
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
        public void Index_Valid_Int1(int index, int expectedResult)
        {
            // Act
            var result = _collectionInt[index];

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForIndex.GetDataForIndexValidInt), MemberType = typeof(MyListSourceDataForIndex))]
        public void Index_Valid_Int2(IMyCollection<int> collection, int index, int expectedResult)
        {
            // Act
            var result = collection[index];

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(102)]
        [InlineData(1000)]
        public void Index_Invalid_Int(int index)
        {
            // Act
            var act = Assert.Throws<IndexOutOfRangeException>(() => _collectionInt[index]);

            // Assert
            Assert.Equal($"Index: {index}, Count objects in collection: {100}", act.Message);
        }

        [Theory]
        [InlineData("Mason", 10, "Anthony", 40)]
        [InlineData("Mason", 10, "Jack", 20)]
        [InlineData("Ethan", 12, "Joseph", 25)]
        [InlineData("Logan", 15, "Anthony", 40)]
        [InlineData("Liam", 0, "Noah", 1)]
        public void Index_Valid_String(string expectedResult1, int index1, string expectedResult2, int index2)
        {
            // Act
            var result1 = _collectionString[index1];
            var result2 = _collectionString[index2];

            // Assert
            result1.Should().Be(expectedResult1);
            result2.Should().Be(expectedResult2);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForIndex.GetDataForIndexValidClass), MemberType = typeof(MyListSourceDataForIndex))]
        public void Index_Valid_Class(Employee expectedResult, int index)
        {
            // Act
            var result = _collectionClass[index];

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
