namespace Lesson9
{
    public class Truck : Vehicle
    {
        private double _carrying = 0.1;

        public double Carrying
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректное значение грузоподъемности для грузовика");
                }
                else
                {
                    _carrying = value;
                }
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Грузоподъемность грузовика: {_carrying}");
        }
    }
}
