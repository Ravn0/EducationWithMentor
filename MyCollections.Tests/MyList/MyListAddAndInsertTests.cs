using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using MyCollections.Tests.SourceData;
using MyCollections.Tests.ClassForTests;

namespace MyCollections.Tests.MyList
{
    public class MyListAddAndInsertTests
    {
        protected IMyCollection<int> _collectionInt;
        protected IMyCollection<string> _collectionString;
        protected IMyCollection<Employee> _collectionClass;

        public MyListAddAndInsertTests()
        {
            _collectionInt = new MyList<int>();
            _collectionString = new MyList<string>();
            _collectionClass = new MyList<Employee>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        public void Add_Valid_Int_By_Count_And_Index_1(int value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 1;

            // Act
            _collectionInt.Add(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Add_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.Add(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Add_Valid_Int_By_Equals(int[] values, IMyCollection<int> expectedСollection)
        {
            // Act
            for (int i = 0; i < values.Length; i++)
            {
                _collectionInt.Add(values[i]);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void Add_Valid_String_By_Count_And_Index(string item1, string item2)
        {
            // Arrange
            var expectedindexItem1 = 0;
            var expectedindexItem2 = 1;
            var expectedCount = 2;

            // Act
            _collectionString.Add(item1);
            _collectionString.Add(item2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(item1);
            _collectionString[expectedindexItem2].Should().Be(item2);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void Add_Valid_String_By_Equals(string item1, string item2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add(item1);
            expectedСollection.Add(item2);

            // Act
            _collectionString.Add(item1);
            _collectionString.Add(item2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Add_Valid_Class_By_Equals(Employee[] values, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < values.Length; i++)
            {
                _collectionClass.Add(values[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        public void InsertInStart_Valid_Int_By_Count_And_Index_1(int value)
        {
            // Arrange
            var expectedIndex = 0;
            var expectedCount = 2;
            _collectionInt.Add(0);

            // Act
            _collectionInt.InsertInStart(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertInStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertInStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.InsertInStart(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertInStartValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertInStart_Valid_Int_By_Equals(int[] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            for (int i = 0; i < values.Length; i++)
            {
                _collectionInt.InsertInStart(values[i]);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "2")]
        [InlineData("s", "a")]
        public void InsertInStart_Valid_String_By_Count_And_Index(string item1, string item2)
        {
            // Arrange
            var expectedindexItem1 = 1;
            var expectedindexItem2 = 0;
            var expectedCount = 3;
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertInStart(item1);
            _collectionString.InsertInStart(item2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedindexItem1].Should().Be(item1);
            _collectionString[expectedindexItem2].Should().Be(item2);
        }

        [Theory]
        [InlineData("tom", "sem")]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("1", "1")]
        [InlineData("s", "s")]
        public void InsertInStart_Valid_String_By_Equals(string item1, string item2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add("Alex");
            expectedСollection.InsertInStart(item1);
            expectedСollection.InsertInStart(item2);
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertInStart(item1);
            _collectionString.InsertInStart(item2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertInStartValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertInStart_Valid_Class_By_Equals(Employee[] values, MyList<Employee> expectedСollection)
        {
            _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });

            for (int i = 0; i < values.Length; i++)
            {
                _collectionClass.InsertInStart(values[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        [InlineData(10, 4)]
        [InlineData(100, 5)]
        [InlineData(1000, 6)]
        [InlineData(10000, 7)]
        public void Insert_Valid_Int_By_Count_And_Index_1(int value, int index)
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
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Insert_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int value, int expectedCount)
        {
            // Act
            collection.Insert(index, value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[index].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Insert_Valid_Int_By_Equals(int[] indexes, int[] values, IMyCollection<int> expectedСollection)
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
        [InlineData(8, "tom", 34, "sem")]
        [InlineData(11, "", 65, "")]
        [InlineData(12, null, 17, null)]
        [InlineData(48, "1", 87, "2")]
        [InlineData(56, "s", 59, "a")]
        public void Insert_Valid_String_By_Count_And_Index(int indexItem1, string item1, int indexItem2, string item2)
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
        public void Insert_Valid_String_By_Equals(int indexItem1, string item1, int indexItem2, string item2)
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
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void Insert_Valid_Class_By_Equals(int[] indexes, Employee[] values, MyList<Employee> expectedСollection)
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

        [Theory]
        [InlineData(new int[] { 0, 10 }, 2, 10, 1)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 4, 4, 3)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 7, -5, 4)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 4, 100, 2)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 10, 0, 0)]
        [InlineData(new int[] { -1, 0, 1 }, 3, 1, 2)]
        public void AddRange_Valid_Int_By_Count_And_Index_1(int[] values, int expectedCount, int expectedValue, int expectedIndex)
        {
            _collectionInt.AddRange(values);

            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void AddRange_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int[] values, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.AddRange(values);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void AddRange_Valid_Int_By_Equals(int[,] values, IMyCollection<int> expectedСollection)
        {
            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.AddRange(myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(2, new string[] { "tom", "sem", "bob" }, "bob", 4, new string[] { "tom", "sem", "bob" }, "sem", 6)]
        [InlineData(1, new string[] { "", "", "" }, "", 6, new string[] { "", "", "", "", "" }, "", 8)]
        [InlineData(0, new string[] { null, null }, null, 2, new string[] { null, null }, null, 4)]
        [InlineData(3, new string[] { "1", "2", "3", "4", "5" }, "4", 7, new string[] { "6", "7", "8", "9", "10" }, "8", 10)]
        [InlineData(4, new string[] { "q", "w", "e", "r", "t", "y" }, "t", 8, new string[] { "a", "s", "d", "f", "g", "h" }, "d", 12)]
        public void AddRange_Valid_String_By_Count_And_Index(int indexItem1, string[] items1, string expectedItem1, int indexItem2, string[] items2, string expectedItem2, int expectedCount)
        {
            // Act
            _collectionString.AddRange(items1);
            _collectionString.AddRange(items2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[indexItem1].Should().Be(expectedItem1);
            _collectionString[indexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(new string[] { "tom", "sem", "bob" }, new string[] { "alex", "sem", "bob" })]
        [InlineData(new string[] { "", "", "" }, new string[] { "", "", "", "", "" })]
        [InlineData(new string[] { null, null }, new string[] { null, null })]
        [InlineData(new string[] { "1", "2", "3", "4", "5" }, new string[] { "6", "7", "8", "9", "10" })]
        [InlineData(new string[] { "q", "w", "e", "r", "t", "y" }, new string[] { "a", "s", "d", "f", "g", "h" })]
        public void AddRange_Valid_String_By_Equals(string[] items1, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.AddRange(items1);
            expectedСollection.AddRange(items2);

            // Act
            _collectionString.AddRange(items1);
            _collectionString.AddRange(items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForAddRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void AddRange_Valid_Class_By_Equals(Employee[,] values, MyList<Employee> expectedСollection)
        {
            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.AddRange(myArray);
            }


            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 1, 10, 3)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 3, 4, 5)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 4, -5, 8)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 2, 100, 5)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, 0, 11)]
        [InlineData(new int[] { -1, 0, 1 }, 2, 1, 4)]
        public void InsertRangeInStart_Valid_Int_By_Count_And_Index_1(int[] value, int expectedIndex, int expectedValue, int expectedCount)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            _collectionInt.InsertRangeInStart(value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeInStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRangeInStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int[] values, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.InsertRangeInStart(values);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeInStartValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRangeInStart_Valid_Int_By_Equals(int[,] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.InsertRangeInStart(myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(5, new string[] { "tom", "sem", "bob" }, "bob", 1, new string[] { "tom", "sem", "bob" }, "sem", 7)]
        [InlineData(6, new string[] { "", "", "" }, "", 0, new string[] { "", "", "", "", "" }, "", 9)]
        [InlineData(3, new string[] { null, null }, null, 0, new string[] { null, null }, null, 5)]
        [InlineData(8, new string[] { "1", "2", "3", "4", "5" }, "4", 2, new string[] { "6", "7", "8", "9", "10" }, "8", 11)]
        [InlineData(10, new string[] { "q", "w", "e", "r", "t", "y" }, "t", 2, new string[] { "a", "s", "d", "f", "g", "h" }, "d", 13)]
        public void InsertRangeInStart_Valid_String_By_Count_And_Index(int indexItem1, string[] items1, string expectedItem1, int indexItem2, string[] items2, string expectedItem2, int expectedCount)
        {
            // Arrange
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertRangeInStart(items1);
            _collectionString.InsertRangeInStart(items2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[indexItem1].Should().Be(expectedItem1);
            _collectionString[indexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(new string[] { "tom", "sem", "bob" }, new string[] { "alex", "sem", "bob" })]
        [InlineData(new string[] { "", "", "" }, new string[] { "", "", "", "", "" })]
        [InlineData(new string[] { null, null }, new string[] { null, null })]
        [InlineData(new string[] { "1", "2", "3", "4", "5" }, new string[] { "6", "7", "8", "9", "10" })]
        [InlineData(new string[] { "q", "w", "e", "r", "t", "y" }, new string[] { "a", "s", "d", "f", "g", "h" })]
        public void InsertRangeInStart_Valid_String_By_Equals(string[] items1, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            expectedСollection.Add("Alex");
            expectedСollection.InsertRangeInStart(items1);
            expectedСollection.InsertRangeInStart(items2);
            _collectionString.Add("Alex");

            // Act
            _collectionString.InsertRangeInStart(items1);
            _collectionString.InsertRangeInStart(items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeInStartValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRangeInStart_Valid_Class_By_Equals(Employee[,] values, MyList<Employee> expectedСollection)
        {
            _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });

            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.InsertRangeInStart(myArray);
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 1, 12, 2, 10)]
        [InlineData(new int[] { -1, 2, 0, 4 }, 3, 14, 4, 2)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -7 }, 5, 17, 9, -5)]
        [InlineData(new int[] { 1, 10, 100, 1000 }, 6, 14, 9, 1000)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 7, 20, 7, 0)]
        [InlineData(new int[] { -1, 0, 1 }, 9, 13, 11, 1)]
        public void InsertRange_Valid_Int_By_Count_And_Index_1(int[] value, int index, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Arrange
            for (int i = 0; i < 10; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            _collectionInt.InsertRange(index, value);

            // Assert
            _collectionInt.Count.Should().Be(expectedCount);
            _collectionInt[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeValidIntByCountAndIndex), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRange_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int[] value, int expectedCount, int expectedIndex, int expectedValue)
        {
            // Act
            collection.InsertRange(index, value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(expectedValue);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeValidIntByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRange_Valid_Int_By_Equals(int[] indexes, int[,] values, IMyCollection<int> expectedСollection)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            var myArray = new int[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionInt.InsertRange(indexes[i], myArray);
            }

            // Assert
            _collectionInt.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(2, new string[] { "tom", "sem", "bob" }, 4, "bob", 54, new string[] { "tom", "sem", "bob" }, 55, "sem", 106)]
        [InlineData(1, new string[] { "", "", "" }, 2, "", 65, new string[] { "", "", "", "", "" }, 67, "", 108)]
        [InlineData(10, new string[] { null, null }, 11, null, 96, new string[] { null, null }, 96, null, 104)]
        [InlineData(3, new string[] { "1", "2", "3", "4", "5" }, 6, "4", 89, new string[] { "6", "7", "8", "9", "10" }, 91, "8", 110)]
        [InlineData(24, new string[] { "q", "w", "e", "r", "t", "y" }, 28, "t", 105, new string[] { "a", "s", "d", "f", "g", "h" }, 107, "d", 112)]
        public void InsertRange_Valid_String_By_Count_And_Index(int indexItem1, string[] items1, int expectedIndexItem1, string expectedItem1, int indexItem2, string[] items2, int expectedIndexItem2, string expectedItem2, int expectedCount)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }


            // Act
            _collectionString.InsertRange(indexItem1, items1);
            _collectionString.InsertRange(indexItem2, items2);

            // Assert
            _collectionString.Count.Should().Be(expectedCount);
            _collectionString[expectedIndexItem1].Should().Be(expectedItem1);
            _collectionString[expectedIndexItem2].Should().Be(expectedItem2);
        }

        [Theory]
        [InlineData(8, new string[] { "tom", "sem", "bob" }, 22, new string[] { "alex", "sem", "bob" })]
        [InlineData(5, new string[] { "", "", "" }, 55, new string[] { "", "", "", "", "" })]
        [InlineData(7, new string[] { null, null }, 76, new string[] { null, null })]
        [InlineData(56, new string[] { "1", "2", "3", "4", "5" }, 90, new string[] { "6", "7", "8", "9", "10" })]
        [InlineData(43, new string[] { "q", "w", "e", "r", "t", "y" }, 99, new string[] { "a", "s", "d", "f", "g", "h" })]
        public void InsertRange_Valid_String_By_Equals(int indexItem1, string[] items1, int indexItem2, string[] items2)
        {
            // Arrange
            var expectedСollection = new MyList<string>();
            for (int i = 0; i < 100; i++)
            {
                expectedСollection.Add("Alex");
            }

            expectedСollection.InsertRange(indexItem1, items1);
            expectedСollection.InsertRange(indexItem2, items2);
            for (int i = 0; i < 100; i++)
            {
                _collectionString.Add("Alex");
            }

            // Act
            _collectionString.InsertRange(indexItem1, items1);
            _collectionString.InsertRange(indexItem2, items2);

            // Assert
            _collectionString.Should().Be(expectedСollection);
        }

        [Theory]
        [MemberData(nameof(MyListSourceDataForAddAndInsert.GetDataForInsertRangeValidClassByEquals), MemberType = typeof(MyListSourceDataForAddAndInsert))]
        public void InsertRange_Valid_Class_By_Equals(int[] indexes, Employee[,] values, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < 100; i++)
            {
                _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });
            }

            var myArray = new Employee[values.GetLength(1)];
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    myArray[j] = values[i, j];
                }

                _collectionClass.InsertRange(indexes[i], myArray);
            }

            _collectionClass.Should().Be(expectedСollection);
        }
    }
}