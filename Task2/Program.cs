namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(4,3);
            Rectangle rectangle2 = new Rectangle(5,8);

            rectangle1.Calculateperimeter();
            rectangle1.CalculateArea();
            rectangle2.Calculateperimeter();
            rectangle2.CalculateArea();
            rectangle1.Display(nameof(rectangle1));
            rectangle2.Display(nameof(rectangle2));

        }
    }
}
