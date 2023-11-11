namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка решения задачи 1
            Product product1 = new Product("name1", "shop1", 10.0);
            Product product2 = new Product("name2", "shop1", 5);
            Console.WriteLine(product1 + product2);
            product1.ShowInfo();
            product2.ShowInfo();

            Warehouse warehouse = new Warehouse();
            Console.WriteLine($"Количество товаров в магазине: {warehouse.Products.Length}");

            warehouse.AddProduct(product1);
            warehouse.AddProduct(product2);
            Console.WriteLine($"Товаров в магазине: {warehouse.Products.Length}");
            foreach (var product in warehouse.Products)
            {
                product.ShowInfo();
            }

            Console.WriteLine("Поиск по имени name1:");
            warehouse.ShowProductInfoByName("name1");
            Console.WriteLine("Поиск по имени nam:");
            warehouse.ShowProductInfoByName("nam");

            Console.WriteLine("Поиск по номеру 1:");
            warehouse.ShowProductInfoByIndex(1);
            Console.WriteLine("Поиск по номеру 4:");
            warehouse.ShowProductInfoByIndex(4);

            Product product3 = new Product("name2", "shop1", 5);
            Console.WriteLine($"Удалили товар: ");
            product3.ShowInfo();
            warehouse.DeleteProduct(product3);
            Console.WriteLine($"Товаров в магазине: {warehouse.Products.Length}");
            foreach (var product in warehouse.Products)
            {
                product.ShowInfo();
            }
            Console.WriteLine($"Удалили товар");
            warehouse.DeleteProduct(new Product("name1", "shop1", 10));
            Console.WriteLine($"Товаров в магазине: {warehouse.Products.Length}");
            foreach (var product in warehouse.Products)
            {
                product.ShowInfo();
            }

            //Проверка решение задачи 2
            Bus taxi = new Bus(70, 4);

            Console.WriteLine($"{Environment.NewLine}Посадка пассажиров");
            taxi.LoadingPassengers("Иванов");
            taxi.LoadingPassengers(new List<string> { "Иванов2", "Иванова", "Иванов3", "Иванова2" });

            taxi.IncreaseSpeed(60);
            taxi.IncreaseSpeed(15);
            taxi.ReduceSpeed(5);
            taxi.ReduceSpeed(66);

            Console.WriteLine($"{Environment.NewLine}Высадка пассажиров");
            taxi.UnloadingPassengers("Петров");
            taxi.UnloadingPassengers(new List<string> { "Иванов2", "Иванова" });

            //Проверка задачи 3
        }
    }
}