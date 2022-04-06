using System.Collections;
using System.Collections.Generic;
using MyCollectionsExample;

namespace ExampleTestMyCollections.SourceData
{
    public static class ExampleClassSourceData
    {
        public static IEnumerable<object[]> GetDataForBuildCar()
        {
            yield return new object[]
            {
                new Car()
                {
                    Name = "car1",
                },
                new Engine()
                {
                    Name = "ferari",
                    Power = 100,
                },
                new Car()
                {
                    Name = "car1",
                    Engine = new Engine()
                    {
                        Name = "ferari",
                        Power = 100,
                    },
                }
            };
            yield return new object[]
            {
                new Car()
                {
                    Name = "asljdfka",
                },
                new Engine()
                {
                    Name = "ferari",
                    Power = 100,
                },
                new Car()
                {
                    Name = "asljdfka",
                    Engine = new Engine()
                    {
                        Name = "ferari",
                        Power = 100,
                    },
                }
            };
        }

    }
}