namespace Exam2
{
    internal class Program
    {
        static void Main()
        {
            Order o1 = new Order();
            o1.AddDish(new Dessert("cake", 90.0m));
            o1.AddDish(new Drink("tea", 10.0m));
            o1.PrintOrder();
        }
    }
}