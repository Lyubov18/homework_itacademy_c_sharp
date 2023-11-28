namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задача 1:");
            Soda fanta = new Soda("orange");
            Soda water = new Soda();
            water.WriteTaste();
            fanta.WriteTaste();

            Console.WriteLine($"{Environment.NewLine}Задача 2:");
            Console.WriteLine($"{Math.Add(2.1, 3.3)}");
            Console.WriteLine($"{Math.Subtract(6.3, 3.3)}");
            Console.WriteLine($"{Math.Multiply(6.3, 2)}");
            Console.WriteLine($"{Math.Divide(6.3, 2)}");

            Console.WriteLine($"{Environment.NewLine}Задача 3:");
            Car firstCar = new Car("black", "kia", 2011);
            Car secondCar = new Car("blue", "geely", 2022);
            firstCar.Start();
            firstCar.Color = "red";
            firstCar.Start();
            firstCar.TurnOff();
            secondCar.Start();
            secondCar.Type = "belgee";
            secondCar.Year = 2023;
            secondCar.TurnOff();
            secondCar.TurnOff();
        }
    }
}