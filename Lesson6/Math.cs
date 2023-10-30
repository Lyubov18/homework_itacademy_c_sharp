namespace Lesson6
{
    public class Math
    {
        public static void Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
        public static void Subtract(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }
        public static void Multiply(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }
        public static void Divide(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }
    }
}
