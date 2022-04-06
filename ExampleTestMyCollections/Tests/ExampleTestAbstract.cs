using ExampleTestMyCollections.SourceData;
using FluentAssertions;
using MyCollectionsExample;
using Xunit;

namespace ExampleTestMyCollections.Tests
{
    public abstract class ExampleTestAbstract
    {
        protected IExampleClass _exampleClass;
        
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        public void Sum_Valid_InlineData_1(int x, int y, int expected)
        {
            var actualResult = _exampleClass.Sum(x, y);

            actualResult.Should().Be(expected);
        }
        
        [Theory]
        [MemberData(nameof(ExampleClassSourceData.GetDataForBuildCar), MemberType = typeof(ExampleClassSourceData))]
        public void BuildCar_Valid(Car car, Engine engine,Car expectedCar)
        {
            var actualResult = _exampleClass.BuildCar(car, engine);

            actualResult.Should().BeEquivalentTo(expectedCar);
        }
    }
}