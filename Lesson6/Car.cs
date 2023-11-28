namespace Lesson6
{
    internal class Car
    {
        private string _color;

        private string _type;

        private int _year;

        private bool _isStarted;

        public Car(string color, string type, int year)
        {
            _color = color;
            _type = type;
            _year = year;
            _isStarted = false;
        }

        public string Color
        {
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Необходимо указать цвет автомобиля");
                }
                else
                {
                    _color = value;
                }
            }
        }

        public string Type
        {
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Необходимо указать тип автомобиля");
                }
                else
                {
                    _type = value;
                }
            }
        }

        public int Year
        {
            set
            {
                if (value < 1885)
                {
                    Console.WriteLine($"Автомобиль не может быть {value} года. Будет установлено значение 0.");
                    value = 0;
                }
                _year = value;
            }
        }

        public void Start()
        {
            if (!_isStarted)
            {
                _isStarted = true;
                Console.WriteLine("Автомобиль заведён");
            }
            else
            {
                Console.WriteLine("Невозможно завести. Автомобиль уже заведен");
            }
        }

        public void TurnOff()
        {
            if (_isStarted)
            {
                _isStarted = false;
                Console.WriteLine("Автомобиль заглушен");
            }
            else
            {
                Console.WriteLine("Невозможно заглушить. Автомобиль уже заглушен");
            }
        }
    }
}
