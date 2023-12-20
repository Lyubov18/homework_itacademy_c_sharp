namespace Exam2
{
    public class Dish
    {
        private string _name = "Something";
        private decimal _price = 0;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public Dish(string name, decimal price) 
        { 
            Name = name;
            Price = price;
        }
    }
}
