namespace TopSystems.TestCase
{
    public class Rectangle : IShape
    {
        public uint Width { get; set; }
        public uint Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Rectangle: Width = {Width}; Height = {Height}.\n");
        }
    }
}
