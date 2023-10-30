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
            set => _color = value;
        }
        public string Type
        {
            set => _type = value;
        }
        public int Year
        {
            set =>  _year = value;
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
