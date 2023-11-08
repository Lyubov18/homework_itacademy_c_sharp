namespace Lesson6
{
    public class Soda
    {
        private string _taste;

        public Soda() { _taste = string.Empty; }

        public Soda(string taste) { _taste = taste; }

        public void WriteTaste()
        {
            if (!string.IsNullOrEmpty(_taste))
            {
                Console.WriteLine($"Taste of your soda is {_taste}");
            }
            else
            {
                Console.WriteLine($"You have a regular soda");
            }
        }
    }
}
