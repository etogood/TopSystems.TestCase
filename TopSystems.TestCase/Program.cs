namespace TopSystems.TestCase
{
    public class Program
    {
        static public void Main(string[] args)
        {

            Rectangle square = new Square(10);
            Rectangle rect = new Rectangle(10, 12);
            Circle circle = new Circle(5);

            square.Draw();
            rect.Draw();
            circle.Draw();
        }
    }
}
