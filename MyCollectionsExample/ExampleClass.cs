namespace MyCollectionsExample
{
    public class ExampleClass:IExampleClass
    {
        public int Sum(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                return 0;
            }
            return x + y;
        }

        public Car BuildCar(Car car, Engine engine)
        {
            car.Engine = engine;

            return car;
        }
    }
}