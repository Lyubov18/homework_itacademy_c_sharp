namespace Lesson9
{
    public class Car : Vehicle
    {
        private int _numberOfDoors = 5;
        private string _fuelType = "Petrol";

        public int NumberOfDoors
        {
            set
            {
                if (value <= 0 || value > 10)
                {
                    Console.WriteLine("Некорректное значение количесва дверей автомобиля");
                }
                else
                {
                    _numberOfDoors = value;
                }
            }
        }
        public string FuelType
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _fuelType = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение количесва дверей автомобиля");
                }
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество дверей в автомобиле: {_numberOfDoors}{Environment.NewLine}" +
                              $"Тип топлива:{_fuelType}");
        }
    }
}
