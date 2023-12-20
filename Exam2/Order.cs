namespace Exam2
{
    public class Order
    {
        private List<Dish> _dishes = new List<Dish>();
        private decimal _fullPrice = 0;

        public decimal FullPrice
        {
            get
            {
                return _fullPrice;
            }
            set
            {
                if (value > 0)
                {
                    _fullPrice = value;
                }
            }
        }

        public List<Dish> Dishes
        {
            get
            {
                return _dishes;
            }
            set
            {
                if (value.Count()>0)
                {
                    _dishes = value;
                }
            }
        }

        public void AddDish(Dish dish)
        { 
            _dishes.Add(dish);
            _fullPrice += dish.Price;
        }

        public void PrintOrder()
        {
            
            foreach (var item in _dishes)
            {   
                Console.WriteLine($"Наименование: {item.Name};     стоимость: {item.Price}");
            }
            Console.WriteLine($"Общая сумма заказа: {_fullPrice}");
        }
    }
}
