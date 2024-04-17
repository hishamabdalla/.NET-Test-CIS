namespace Task5
{
    internal class Program
    {
        public delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers: ");
            string[] input = Console.ReadLine().Split(" ");

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            MathOperation Add = Calculator.addition;
            MathOperation subtract = Calculator.subtraction;
            MathOperation multiply = Calculator.multiplication;
            MathOperation divide = Calculator.division;

            Console.WriteLine($"Addition: {x} + {y} = {Add(x, y)}");

            Console.WriteLine($"Subtraction: {x} - {y} = {subtract(x, y)}");

            Console.WriteLine($"Multiplication: {x} * {y} = {multiply(x, y)}");

            Console.WriteLine($"Division: {x} / {y} = {divide(x, y)}");
        }
       

    }
}
