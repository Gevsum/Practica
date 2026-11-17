namespace MyMathLibrary
{
    public class MathOperations
    {
        public void PrintHello()
        {
            Console.WriteLine("Привет из DLL библиотеки!");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine($"Сообщение из библиотеки: {message}");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
