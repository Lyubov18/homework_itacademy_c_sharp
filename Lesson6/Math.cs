namespace Lesson6
{
    public class Math
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                return firstNumber;
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
    }
}
