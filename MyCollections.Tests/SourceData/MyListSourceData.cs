using System.Collections.Generic;
using MyCollections.Generic;

namespace MyCollections.Tests.SourceData
{
    public class MyListSourceData
    {
        public static IEnumerable<object[]> GetDataForAdd()
        {
            var collection = new MyList<int>();
            for (int i = 0; i < 1; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                2,
                1,
            };

            collection = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                11,
                10,
            };
            collection = new MyList<int>();
            for (int i = 0; i < 100; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                collection,
                10,
                101,
                100,
            };
        }
        public static IEnumerable<object[]> GetDataForAddTest()
        {
            var collection = new MyList<int>();
            for (int i = 0; i < 1; i++)
            {
                collection.Add(i);
            }

            yield return new object[]
            {
                0,
                collection,
            };
        }
    }
}