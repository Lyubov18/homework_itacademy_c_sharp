using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 7, 2, 6, 4 };

            // Сортируем коллекцию по возрастанию
            var sortedNumbers = numbers.OrderBy(n => n).ToList();

            int startIndex = numbers.Count % 2 == 0 ? numbers.Count / 2 : numbers.Count / 2 + 1;

            var secondHalfSquaredDescending = sortedNumbers.Skip(startIndex).OrderByDescending(n => n * n).ToList();

            // Выводим результат
            Console.WriteLine("Исходная коллекция: " + string.Join(", ", numbers));
            Console.WriteLine("Отсортированная по возрастанию: " + string.Join(", ", sortedNumbers));
            Console.WriteLine("Квадраты элементов второй половины (отсортированные по убыванию): " + string.Join(", ", secondHalfSquaredDescending));
        }
    }
}