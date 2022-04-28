using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListFindTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListFindTests()
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
        public void Find_Valid_Int1(int index, int expectedResult)
        {
            // Act
            var result = _collectionInt.Find(index);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForFind.GetDataForFindValidInt), MemberType = typeof(MyListSourceDataForFind))]
        public void Find_Valid_Int2(IMyCollection<int> collection, int index, int expectedResult)
        {
            // Act
            var result = collection.Find(index);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(102)]
        [InlineData(1000)]
        public void Find_Invalid_Int(int index)
        {
            // Act
            Action act = () => _collectionInt.Find(index);

            // Assert
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Theory]
        [InlineData("Mason", 10, "Anthony", 40)]
        [InlineData("Mason", 10, "Jack", 20)]
        [InlineData("Ethan", 12, "Joseph", 25)]
        [InlineData("Logan", 15, "Anthony", 40)]
        [InlineData("Liam", 0, "Noah", 1)]
        public void Find_Valid_String(string expectedResult1, int index1, string expectedResult2, int index2)
        {
            // Act
            var result1 = _collectionString.Find(index1);
            var result2 = _collectionString.Find(index2);

            // Assert
            result1.Should().Be(expectedResult1);
            result2.Should().Be(expectedResult2);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForFind.GetDataForFindValidClass), MemberType = typeof(MyListSourceDataForFind))]
        public void Find_Valid_Class(Employee expectedResult, int index)
        {
            // Act
            var result = _collectionClass.Find(index);

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
