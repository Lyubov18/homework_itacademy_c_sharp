namespace Lesson9
{
    internal class ElectricCar : Car
    {
        private double _maxDistanceSingleCharge = 0;
        private int _chargeLevel = 0;

        public double MaxDistanceSingleCharge
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректное значение запаса хода на одном заряде электрокара.");
                }
                else
                {
                    _maxDistanceSingleCharge = value;
                }
            }
            get => _maxDistanceSingleCharge;
        }
        public int ChargeLevel
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Некорректное значение уровня заряда электрокара.");
                }
                else
                {
                    _chargeLevel = value;
                }
            }
            get => _chargeLevel;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Максимальное расстояние на одном заряде: {_maxDistanceSingleCharge}{Environment.NewLine}" +
                              $"Уровень заряда: {_chargeLevel}{Environment.NewLine}");
        }
    }
}
