namespace Lesson8
{
    internal class Goods
    {
        private string _name;

        private string _shopName;

        private double _price;

        private bool _isValid;
        public double Price 
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
                else
                {
                    Console.WriteLine("Цена должна быть больше нуля");
                    _isValid = false;
                }
            } 
        }
        public string ShopName
        {
            get
            {
                return _shopName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _shopName = value;
                }
                else
                {
                    Console.WriteLine("Название магазина не должно быть пустым");
                    _isValid = false;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Название товара не может быть пустым");
                    _isValid = false;
                }
            }
        }

        public Goods (string name, string shopName, double price)
        {
            Name = name;
            ShopName = shopName;
            Price = price;
        }

    }
}
