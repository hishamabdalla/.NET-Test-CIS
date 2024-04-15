namespace Task1
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            int num1, num2;
            string[] input = Console.ReadLine().Split(" ");
            num1 = int.Parse(input[0]);
            num2 = int.Parse(input[1]);
            Console.WriteLine(Sum(num1, num2));


        }
    }
}
