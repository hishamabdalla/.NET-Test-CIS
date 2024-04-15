namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 4);
            Shape circle = new Circle(3);

            rectangle.Display();
            circle.Display();
        }
    }
}
