namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere firstSphere = new Sphere();
            Console.WriteLine($"Центр окружности: {firstSphere.GetCenter()}");
            Console.WriteLine(firstSphere.Radius);
            firstSphere.SetCenter(3, 3, -1);
            Console.WriteLine($"Центр окружности: {firstSphere.GetCenter()}");
            firstSphere.Radius = 10;
            Console.WriteLine(firstSphere.Radius);
            Console.WriteLine($"Площадь поверхности сферы: {firstSphere.GetSquare()}");
            Console.WriteLine($"Объём сферы: {firstSphere.GetVolume()}");
            Console.WriteLine(firstSphere.IsPointInside(4, 5, 3));
            Console.WriteLine(firstSphere.IsPointInside(14, 3, -1));

            Console.WriteLine($"{Environment.NewLine}Вторая сфера");
            Sphere secondSphere = new Sphere(5, 0, 1.3, 9);
            Console.WriteLine($"Центр окружности: {secondSphere.GetCenter()}");
            Console.WriteLine(secondSphere.Radius);

            Console.WriteLine($"{Environment.NewLine}Третья сфера");
            Sphere thirdSphere = new Sphere(2.3);
            Console.WriteLine($"Центр окружности: {thirdSphere.GetCenter()}");
            Console.WriteLine(thirdSphere.Radius);
        }
    }
}
