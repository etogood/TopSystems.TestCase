namespace TopSystems.TestCase
{
    public class Square : Rectangle
    {
        public uint SideLenght => Width & Height;

        private uint _width;
        public new uint Width
        {
            get => _width; 
            set
            {
                _height = value;
                _width = value;
            }
        }

        private uint _height;
        public new uint Height
        {
            get => _height;
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Square: Side Lenght = {SideLenght}.\n");
        }
        public Square()
        {
            Width = 0;
            Height = 0;
        }

        public Square(uint sizeLenght)
        {
            Width = sizeLenght;
            Height = sizeLenght;
        }
    }
}
