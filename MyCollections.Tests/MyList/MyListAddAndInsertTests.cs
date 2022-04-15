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
        [MemberData(nameof(MyListSourceData.GetDataForAddValidIntByCountAndIndex), MemberType = typeof(MyListSourceData))]
        public void Add_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.Add(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceData.GetDataForAddValidIntByEquals), MemberType = typeof(MyListSourceData))]
        public void Add_Valid_Int_By_Equals(int[] value, IMyCollection<int> expectedСollection)
        {
            // Act
            for (int i = 0; i < value.Length; i++)
            {
                _collectionInt.Add(value[i]);
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
        [MemberData(nameof(MyListSourceData.GetDataForAddValidClassByEquals), MemberType = typeof(MyListSourceData))]
        public void Add_Valid_Class_By_Equals(Employee[] value, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < value.Length; i++)
            {
                _collectionClass.Add(value[i]);
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
        [MemberData(nameof(MyListSourceData.GetDataForInsertInStartValidIntByCountAndIndex), MemberType = typeof(MyListSourceData))]
        public void InsertInStart_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            // Act
            collection.InsertInStart(value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceData.GetDataForInsertInStartValidIntByEquals), MemberType = typeof(MyListSourceData))]
        public void InsertInStart_Valid_Int_By_Equals(int[] value, IMyCollection<int> expectedСollection)
        {
            // Arrange
            _collectionInt.Add(0);

            // Act
            for (int i = 0; i < value.Length; i++)
            {
                _collectionInt.InsertInStart(value[i]);
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
        [MemberData(nameof(MyListSourceData.GetDataForInsertInStartValidClassByEquals), MemberType = typeof(MyListSourceData))]
        public void InsertInStart_Valid_Class_By_Equals(Employee[] value, MyList<Employee> expectedСollection)
        {
            _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });

            for (int i = 0; i < value.Length; i++)
            {
                _collectionClass.InsertInStart(value[i]);
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
        [MemberData(nameof(MyListSourceData.GetDataForInsertValidIntByCountAndIndex), MemberType = typeof(MyListSourceData))]
        public void Insert_Valid_Int_By_Count_And_Index_2(IMyCollection<int> collection, int index, int value, int expectedCount)
        {
            // Act
            collection.Insert(index, value);

            // Assert
            collection.Count.Should().Be(expectedCount);
            collection[index].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceData.GetDataForInsertValidIntByEquals), MemberType = typeof(MyListSourceData))]
        public void Insert_Valid_Int_By_Equals(int[] index, int[] value, IMyCollection<int> expectedСollection)
        {
            // Arrange
            for (int i = 0; i < 100; i++)
            {
                _collectionInt.Add(i);
            }

            // Act
            for (int i = 0; i < value.Length; i++)
            {
                _collectionInt.Insert(index[i], value[i]);
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
        [MemberData(nameof(MyListSourceData.GetDataForInsertValidClassByEquals), MemberType = typeof(MyListSourceData))]
        public void Insert_Valid_Class_By_Equals(int[] index, Employee[] value, MyList<Employee> expectedСollection)
        {
            for (int i = 0; i < 100; i++)
            {
                _collectionClass.Add(new Employee { Name = "Alex", Age = 23 });
            }

            for (int i = 0; i < value.Length; i++)
            {
                _collectionClass.Insert(index[i], value[i]);
            }

            _collectionClass.Should().Be(expectedСollection);
        }

        [Theory]
        [InlineData(new int[] { 0, 10 }, 2)]
        public void AddRange_Valid_1(int[] values, int expectedCount)
        {
            _collectionInt.AddRange(values);

            _collectionInt.Count.Should().Be(expectedCount);
        }

        [Fact]
        public void AddRange_Valid_Int()
        {
            // Arrange
            var item1 = new int[] { 1, 2, 3, 4 };
            var item2 = new int[] { 2, 3, 4, 5 };
            var expected = new MyList<int>();
            expected.AddRange(new int[] { 1, 2, 3, 4 });
            expected.AddRange(new int[] { 2, 3, 4, 5 });

            // Act
            var actualMyList = new MyList<int>();
            actualMyList.AddRange(item1);
            actualMyList.AddRange(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AddRange_Valid_String()
        {
            // Arrange
            var item1 = new string[] { "Tom", "Alex" };
            var item2 = new string[] { "Pavlo", "Ivan" };
            var expected = new MyList<string>();
            expected.AddRange(new string[] { "Tom", "Alex" });
            expected.AddRange(new string[] { "Pavlo", "Ivan" });

            // Act
            var actualMyList = new MyList<string>();
            actualMyList.AddRange(item1);
            actualMyList.AddRange(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRangeInStart_Valid_Int()
        {
            // Arrange
            var item1 = new int[] { 1, 2, 3, 4 };
            var item2 = new int[] { 2, 3, 4, 5 };
            var expected = new MyList<int>();
            expected.InsertRangeInStart(new int[] { 1, 2, 3, 4 });
            expected.InsertRangeInStart(new int[] { 2, 3, 4, 5 });

            // Act
            var actualMyList = new MyList<int>();
            actualMyList.InsertRangeInStart(item1);
            actualMyList.InsertRangeInStart(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRangeInStart_Valid_String()
        {
            // Arrange
            var item1 = new string[] { "Tom", "Alex" };
            var item2 = new string[] { "Pavlo", "Ivan" };
            var expected = new MyList<string>();
            expected.InsertRangeInStart(new string[] { "Tom", "Alex" });
            expected.InsertRangeInStart(new string[] { "Pavlo", "Ivan" });

            // Act
            var actualMyList = new MyList<string>();
            actualMyList.InsertRangeInStart(item1);
            actualMyList.InsertRangeInStart(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRangeInStart_Valid_Double()
        {
            // Arrange
            var item1 = new double[] { 1.1, 1.2, 1.3 };
            var item2 = new double[] { 5.1, 6.2, 7.3 };
            var expected = new MyList<double>();
            expected.InsertRangeInStart(new double[] { 1.1, 1.2, 1.3 });
            expected.InsertRangeInStart(new double[] { 5.1, 6.2, 7.3 });

            // Act
            var actualMyList = new MyList<double>();
            actualMyList.InsertRangeInStart(item1);
            actualMyList.InsertRangeInStart(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRangeInStart_Invalid_Char()
        {
            // Arrange
            var item1 = new char[] { '1', '2', '3' };
            var item2 = new char[] { 'q', 'w', 'e' };
            var expected = new MyList<char>();
            expected.InsertRangeInStart(new char[] { '1', '2', '3', '4' });
            expected.InsertRangeInStart(new char[] { 'q', 'w', 'e' });

            // Act
            var actualMyList = new MyList<char>();
            actualMyList.InsertRangeInStart(item1);
            actualMyList.InsertRangeInStart(item2);

            // Assert
            actualMyList.Should().NotBeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRange_Valid_Int()
        {
            // Arrange
            var item1 = new int[] { 1, 2, 3, 4, 5 };
            int index1 = 3;
            var item2 = new int[] { 6, 7, 8, 9, 10 };
            int index2 = 8;
            var expected = new MyList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            expected.Add(8);
            expected.Add(9);
            expected.Add(10);
            expected.InsertRange(3, new int[] { 1, 2, 3, 4, 5 });
            expected.InsertRange(8, new int[] { 6, 7, 8, 9, 10 });

            // Act
            var actualMyList = new MyList<int>();
            actualMyList.Add(1);
            actualMyList.Add(2);
            actualMyList.Add(3);
            actualMyList.Add(4);
            actualMyList.Add(5);
            actualMyList.Add(6);
            actualMyList.Add(7);
            actualMyList.Add(8);
            actualMyList.Add(9);
            actualMyList.Add(10);
            actualMyList.InsertRange(index1, item1);
            actualMyList.InsertRange(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRange_Valid_String()
        {
            // Arrange
            var item1 = new string[] { "Tom", "Pavlo" };
            int index1 = 0;
            var item2 = new string[] { "Ivan", "Igor" };
            int index2 = 11;
            var expected = new MyList<string>();
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.Add("Alex");
            expected.InsertRange(0, new string[] { "Tom", "Pavlo" });
            expected.InsertRange(11, new string[] { "Ivan", "Igor" });

            // Act
            var actualMyList = new MyList<string>();
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.Add("Alex");
            actualMyList.InsertRange(index1, item1);
            actualMyList.InsertRange(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRange_Valid_Double()
        {
            // Arrange
            var item1 = new double[] { 1.1, 1.2, 1.3, 1.4 };
            int index1 = 2;
            var item2 = new double[] { 5.1, 6.2, 7.3, 8.4, 9.5 };
            int index2 = 5;
            var expected = new MyList<double>();
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.Add(1.1);
            expected.InsertRange(2, new double[] { 1.1, 1.2, 1.3, 1.4 });
            expected.InsertRange(5, new double[] { 5.1, 6.2, 7.3, 8.4, 9.5 });

            // Act
            var actualMyList = new MyList<double>();
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.Add(1.1);
            actualMyList.InsertRange(index1, item1);
            actualMyList.InsertRange(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRange_Invalid_Char()
        {
            // Arrange
            var item1 = new char[] { '1', '2', '3' };
            int index1 = 4;
            var item2 = new char[] { 'q', 'w', 'e' };
            int index2 = 4;
            var expected = new MyList<char>();
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.Add('1');
            expected.InsertRange(5, new char[] { '1', '2', '3', '4' });
            expected.InsertRange(6, new char[] { 'a', 's', 'd' });

            // Act
            var actualMyList = new MyList<char>();
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.Add('1');
            actualMyList.InsertRange(index1, item1);
            actualMyList.InsertRange(index2, item2);

            // Assert
            actualMyList.Should().NotBeEquivalentTo(expected);
        }
    }
}