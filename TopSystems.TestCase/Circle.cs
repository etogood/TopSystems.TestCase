namespace TopSystems.TestCase
{
    public class Circle : IShape
    {
        private const double PI = 3.14159265;

        public uint Radius { get; set; }

        public uint Diameter => Radius * 2;

        public double Area => PI * Radius * Radius;

        public Circle(uint radius)
        {
            Radius = radius;
        }

        public Circle()
        {
            Radius = 0;
        }
        public void Draw()
        {
            Console.WriteLine($"Circle: Radius = {Radius}; Area = {Area}.\n");
        }
    }
}
