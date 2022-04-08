using System;
using Xunit;
using MyCollections.Generic;
using FluentAssertions;
using System.Collections.Generic;
using MyCollections.Tests.SourceData;

namespace MyCollections.Tests.MyList
{
    public class MyListAddAndInsertTests
    {
        protected IMyCollection<int> _collection;

        public MyListAddAndInsertTests()
        {
            _collection = new MyList<int>();
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(10, 1)]
        [InlineData(100, 1)]
        [InlineData(1000, 1)]
        [InlineData(10000, 1)]
        public void Add_Valid_Int_1(int value, int expectedCount)
        {
            var expectedIndex = 0;
            _collection.Add(value);

            _collection.Count.Should().Be(expectedCount);
            _collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [MemberData(nameof(MyListSourceData.GetDataForAdd), MemberType = typeof(MyListSourceData))]
        public void Add_Valid_Int_2(IMyCollection<int> collection, int value, int expectedCount, int expectedIndex)
        {
            collection.Add(value);

            collection.Count.Should().Be(expectedCount);
            collection[expectedIndex].Should().Be(value);
        }

        [Theory]
        [InlineData(new int[] {0, 10}, 2)]
        public void AddRange_Valid_1(int[] values, int expectedCount)
        {
            _collection.AddRange(values);

            _collection.Count.Should().Be(expectedCount);
        }

        [Fact]
        public void Add_Valid_Int()
        {
            // Arrange
            int item1 = 1;
            int item2 = 2;
            var expected = new MyList<int>();
            expected.Add(1);
            expected.Add(2);

            // Act
            var actualMyList = new MyList<int>();
            actualMyList.Add(item1);
            actualMyList.Add(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("tom", 0, "sem", 1, 2)]
        [InlineData("", 0, "", 1, 2)]
        [InlineData(null, 0, null, 1, 2)]
        [InlineData("1", 0, "1", 1, 2)]
        [InlineData("s", 0, "s", 1, 2)]
        public void Add_Valid_String(string item1, int indexItem1, string item2, int indexItem2, int expectedCount)
        {
            // Act
            var actualMyList = new MyList<string>();
            actualMyList.Add(item1);
            actualMyList.Add(item2);

            // Assert
            actualMyList.Count.Should().Be(expectedCount);
            actualMyList[indexItem1].Should().Be(item1);
            actualMyList[indexItem2].Should().Be(item2);
        }

        [Fact]
        public void Add_Valid_Double()
        {
            // Arrange
            double item1 = 1.23;
            double item2 = 5.5;
            var expected = new MyList<double>();
            expected.Add(1.23);
            expected.Add(5.5);

            // Act
            var actualMyList = new MyList<double>();
            actualMyList.Add(item1);
            actualMyList.Add(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Add_Invalid_Char()
        {
            // Arrange
            char item1 = '1';
            char item2 = 'f';
            var expected = new MyList<char>();
            expected.Add('4');
            expected.Add('f');

            // Act
            var actualMyList = new MyList<char>();
            actualMyList.Add(item1);
            actualMyList.Add(item2);

            // Assert
            actualMyList.Should().NotBe(expected);
        }

        [Fact]
        public void InsertInStart_Valid_Int()
        {
            // Arrange
            int item1 = 1;
            int item2 = 2;
            var expected = new MyList<int>();
            expected.InsertInStart(1);
            expected.InsertInStart(2);

            // Act
            var actualMyList = new MyList<int>();
            actualMyList.InsertInStart(item1);
            actualMyList.InsertInStart(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertInStart_Valid_String()
        {
            // Arrange
            string item1 = "Tom";
            string item2 = "Alex";
            string item3 = "Pavlo";
            var expected = new MyList<string>();
            expected.InsertInStart("Tom");
            expected.InsertInStart("Alex");
            expected.InsertInStart("Pavlo");

            // Act
            var actualMyList = new MyList<string>();
            actualMyList.InsertInStart(item1);
            actualMyList.InsertInStart(item2);
            actualMyList.InsertInStart(item3);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertInStart_Valid_Double()
        {
            // Arrange
            double item1 = 1.23;
            double item2 = 5.5;
            var expected = new MyList<double>();
            expected.InsertInStart(1.23);
            expected.InsertInStart(5.5);

            // Act
            var actualMyList = new MyList<double>();
            actualMyList.InsertInStart(item1);
            actualMyList.InsertInStart(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InsertInStart_Invalid_Char()
        {
            // Arrange
            char item1 = '1';
            char item2 = 'f';
            var expected = new MyList<char>();
            expected.InsertInStart('4');
            expected.InsertInStart('f');

            // Act
            var actualMyList = new MyList<char>();
            actualMyList.InsertInStart(item1);
            actualMyList.InsertInStart(item2);

            // Assert
            actualMyList.Should().NotBeEquivalentTo(expected);
        }

        [Fact]
        public void Insert_Valid_Int()
        {
            // Arrange
            int item1 = 1;
            int index1 = 3;
            int item2 = 2;
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
            expected.Insert(3, 1);
            expected.Insert(8, 2);

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
            actualMyList.Insert(index1, item1);
            actualMyList.Insert(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Insert_Valid_String()
        {
            // Arrange
            string item1 = "Tom";
            int index1 = 0;
            string item2 = "Pavlo";
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
            expected.Insert(0, "Tom");
            expected.Insert(11, "Pavlo");

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
            actualMyList.Insert(index1, item1);
            actualMyList.Insert(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Insert_Valid_Double()
        {
            // Arrange
            double item1 = 10.23;
            int index1 = 2;
            double item2 = 5.5;
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
            expected.Insert(2, 10.23);
            expected.Insert(5, 5.5);

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
            actualMyList.Insert(index1, item1);
            actualMyList.Insert(index2, item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Insert_Invalid_Char()
        {
            // Arrange
            char item1 = '1';
            int index1 = 4;
            char item2 = 'f';
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
            expected.Insert(5, '3');
            expected.Insert(6, 't');

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
            actualMyList.Insert(index1, item1);
            actualMyList.Insert(index2, item2);

            // Assert
            actualMyList.Should().NotBeEquivalentTo(expected);
        }

        [Fact]
        public void AddRange_Valid_Int()
        {
            // Arrange
            var item1 = new int[] {1, 2, 3, 4};
            var item2 = new int[] {2, 3, 4, 5};
            var expected = new MyList<int>();
            expected.AddRange(new int[] {1, 2, 3, 4});
            expected.AddRange(new int[] {2, 3, 4, 5});

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
            var item1 = new string[] {"Tom", "Alex"};
            var item2 = new string[] {"Pavlo", "Ivan"};
            var expected = new MyList<string>();
            expected.AddRange(new string[] {"Tom", "Alex"});
            expected.AddRange(new string[] {"Pavlo", "Ivan"});

            // Act
            var actualMyList = new MyList<string>();
            actualMyList.AddRange(item1);
            actualMyList.AddRange(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AddRange_Valid_Double()
        {
            // Arrange
            var item1 = new double[] {1.1, 1.2, 1.3};
            var item2 = new double[] {5.1, 6.2, 7.3};
            var expected = new MyList<double>();
            expected.AddRange(new double[] {1.1, 1.2, 1.3});
            expected.AddRange(new double[] {5.1, 6.2, 7.3});

            // Act
            var actualMyList = new MyList<double>();
            actualMyList.AddRange(item1);
            actualMyList.AddRange(item2);

            // Assert
            actualMyList.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AddRange_Invalid_Char()
        {
            // Arrange
            var item1 = new char[] {'1', '2', '3'};
            var item2 = new char[] {'q', 'w', 'e'};
            var expected = new MyList<char>();
            expected.AddRange(new char[] {'1', '2', '3', '4'});
            expected.AddRange(new char[] {'q', 'w', 'e'});

            // Act
            var actualMyList = new MyList<char>();
            actualMyList.AddRange(item1);
            actualMyList.AddRange(item2);

            // Assert
            actualMyList.Should().NotBeEquivalentTo(expected);
        }

        [Fact]
        public void InsertRangeInStart_Valid_Int()
        {
            // Arrange
            var item1 = new int[] {1, 2, 3, 4};
            var item2 = new int[] {2, 3, 4, 5};
            var expected = new MyList<int>();
            expected.InsertRangeInStart(new int[] {1, 2, 3, 4});
            expected.InsertRangeInStart(new int[] {2, 3, 4, 5});

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
            var item1 = new string[] {"Tom", "Alex"};
            var item2 = new string[] {"Pavlo", "Ivan"};
            var expected = new MyList<string>();
            expected.InsertRangeInStart(new string[] {"Tom", "Alex"});
            expected.InsertRangeInStart(new string[] {"Pavlo", "Ivan"});

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
            var item1 = new double[] {1.1, 1.2, 1.3};
            var item2 = new double[] {5.1, 6.2, 7.3};
            var expected = new MyList<double>();
            expected.InsertRangeInStart(new double[] {1.1, 1.2, 1.3});
            expected.InsertRangeInStart(new double[] {5.1, 6.2, 7.3});

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
            var item1 = new char[] {'1', '2', '3'};
            var item2 = new char[] {'q', 'w', 'e'};
            var expected = new MyList<char>();
            expected.InsertRangeInStart(new char[] {'1', '2', '3', '4'});
            expected.InsertRangeInStart(new char[] {'q', 'w', 'e'});

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
            var item1 = new int[] {1, 2, 3, 4, 5};
            int index1 = 3;
            var item2 = new int[] {6, 7, 8, 9, 10};
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
            expected.InsertRange(3, new int[] {1, 2, 3, 4, 5});
            expected.InsertRange(8, new int[] {6, 7, 8, 9, 10});

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
            var item1 = new string[] {"Tom", "Pavlo"};
            int index1 = 0;
            var item2 = new string[] {"Ivan", "Igor"};
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
            expected.InsertRange(0, new string[] {"Tom", "Pavlo"});
            expected.InsertRange(11, new string[] {"Ivan", "Igor"});

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
            var item1 = new double[] {1.1, 1.2, 1.3, 1.4};
            int index1 = 2;
            var item2 = new double[] {5.1, 6.2, 7.3, 8.4, 9.5};
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
            expected.InsertRange(2, new double[] {1.1, 1.2, 1.3, 1.4});
            expected.InsertRange(5, new double[] {5.1, 6.2, 7.3, 8.4, 9.5});

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
            var item1 = new char[] {'1', '2', '3'};
            int index1 = 4;
            var item2 = new char[] {'q', 'w', 'e'};
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
            expected.InsertRange(5, new char[] {'1', '2', '3', '4'});
            expected.InsertRange(6, new char[] {'a', 's', 'd'});

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