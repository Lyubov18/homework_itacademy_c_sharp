namespace Lesson9
{
    public class Vehicle
    {
        private double _weight = 0.1;
        private double _maxSpeed = 0.1;

        public double Weight
        {
            set 
            {
                if (value <= 0) 
                {
                    Console.WriteLine("Некорректное значение веса транспортного средства");
                }
                else 
                { 
                    _weight = value;
                }
            }
            get => _weight;          
        }

        public double MaxSpeed
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректное значение максимальной скорости транспортного средства");
                }
                else
                {
                    _maxSpeed = value;
                }
            }
            get => _maxSpeed;            
        }

        virtual public void DisplayInfo()
        {
            Console.WriteLine($"Вес странспортного средства: {_weight}{Environment.NewLine}" +
                              $"Максимальная скорость:{_maxSpeed}");
        }
    }
}
