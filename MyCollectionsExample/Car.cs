namespace MyCollectionsExample
{
    public class Car
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public Engine Engine { get; set; }
    }

    public class Engine
    {
        public string Name { get; set; }
        public int Power { get; set; }
    }
}