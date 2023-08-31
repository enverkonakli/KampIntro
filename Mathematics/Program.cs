namespace Mathematics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(5, 6);
            calculator.Divide(8, 2);

            Console.WriteLine("Hello, World!");
        }
    }
}