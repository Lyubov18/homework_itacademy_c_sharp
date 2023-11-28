namespace Lesson8
{
    internal class Warehouse
    {
        private List<Product> _products = new List<Product>();

        public List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.IsValid)
            {
                _products.Add(product);               
            }
            else
            {
                Console.WriteLine("Невозможно добавить товар");
            }
        }

        public void DeleteProduct(Product product)
        {
            if (product.IsValid)
            {
                _products.Remove(product);
            }
            else
            {
                Console.WriteLine("Невозможно удалить товар");
            }
        }

        public void ShowProductInfoByIndex(int index)
        {
            if (index >= 0 & index < _products.Count)
            {
                _products[index].ShowInfo();
            }
            else
            {
                Console.WriteLine("Товара с таким индексом не существует");
            }
        }

        public void ShowProductInfoByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                foreach (Product product in _products)
                {
                    if (product.Name.Equals(name))
                    {
                        product.ShowInfo();
                    }
                }
            }
            else
            {
                Console.WriteLine("Товара с таким именем не существует");
            }
        }
    }
}
