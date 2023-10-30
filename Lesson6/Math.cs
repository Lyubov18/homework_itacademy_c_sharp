namespace Lesson6
{
    public class Math
    {
        public static void Add(double var1, double var2) 
        {
            Console.WriteLine($"{var1} + {var2} = {var1 + var2}");
        }
        public static void Subtract(double var1, double var2)
        {
            Console.WriteLine($"{var1} - {var2} = {var1 - var2}");
        }
        public static void Multiply(double var1, double var2)
        {
            Console.WriteLine($"{var1} * {var2} = {var1 * var2}");
        }
        public static void Divide(double var1, double var2)
        {
            Console.WriteLine($"{var1} / {var2} = {var1 / var2}");
        }
    }
}
