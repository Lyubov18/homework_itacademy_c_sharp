
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine($"Введите номер задачи:{Environment.NewLine} 1 - Маша и телефон{Environment.NewLine}" +
                                                                            $" 2 - Вывод чисел Фибоначчи{Environment.NewLine}" +
                                                                            $" 3 - Числа кратные 17 от 100 до 200{Environment.NewLine}" +
                                                                            $" 4 - Вычисление суммы ряда{Environment.NewLine}" +
                                                                            $" 0 - Выход{Environment.NewLine}"); ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1:
                            SavingMoney();
                            break;

                        case 2:
                            Fibonachi();
                            break;

                        case 3:
                            MultipleOfSeventeen();
                            break;

                        case 4:
                            SumOfSeries();
                            break;

                        case 0:
                            break;

                        default:
                            Console.WriteLine($"Введенное значение некорректно, повторите попытку{Environment.NewLine}");
                            break;
                    }
                }
                else
                {
                    n = 1;
                }

            }



            void SavingMoney()
            {
                Console.Write("Сколько рублей Маша откладывает в день: ");
                string inputMoneyADay = Console.ReadLine();
                Console.Write("Сколько стоит телефон: ");
                string inputPhonePrice = Console.ReadLine();
                if (!(string.IsNullOrWhiteSpace(inputPhonePrice) | string.IsNullOrWhiteSpace(inputMoneyADay)))
                {
                    if ((double.TryParse(inputPhonePrice, out double phonePrice) & phonePrice > 0) & (double.TryParse(inputMoneyADay, out double moneyADay) & moneyADay > 0))
                    {
                        double numberOfFullWeeks = Math.Truncate(Math.Ceiling(phonePrice / moneyADay) / 6);
                        double remainder = Math.Ceiling(phonePrice / moneyADay) - numberOfFullWeeks * 6;
                        double numberOfDays = numberOfFullWeeks * 7 + remainder;
                        if (remainder == 0)
                        {
                            Console.WriteLine($"Всего дней понадобится: {--numberOfDays}{Environment.NewLine}");
                        }
                        else
                        {
                            Console.WriteLine($"Всего дней понадобится: {numberOfDays}{Environment.NewLine}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Введены некорректные значения сумм{Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"Ни одна из сумм не может быть пустой строкой{Environment.NewLine}");
                }
            }

            void Fibonachi()
            {
                Console.Write("Введите количество элементов последовательности: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (int.TryParse(input, out int number) & number > 0)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine(FibonachiSum(i));
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Введено некорректное значение{Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"Введена пустая строка{Environment.NewLine}");
                }
            }

            int FibonachiSum(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    int sum = FibonachiSum(n - 1) + FibonachiSum(n - 2);
                    return sum;
                }
            }

            void MultipleOfSeventeen()
            {
                int counter = 0;
                Console.Write("Числа в диапазоне от 100 до 200, которые без остатка делятся на 17: ");
                for (int i = 100; i <= 200; i++)
                {
                    if (i % 17 == 0)
                    {
                        Console.Write($" {i}");
                        counter++;
                    }
                }
                Console.WriteLine($"{Environment.NewLine}Количество чисел: {counter}{Environment.NewLine}");
            }

            void SumOfSeries()
            {

                Console.Write("Введите натуральное число от 1 до 10000: ");
                if (int.TryParse(Console.ReadLine(), out int N) & N > 0 & N <= 10000)
                {
                    double sum = 0;
                    for (int n = 1; n <= N; n++)
                    {
                        if (n % 2 == 0)
                        {
                            sum += 1.0 / n;
                        }
                        else
                        {
                            sum -= 1.0 / n; 
                        }
                    }
                    Console.WriteLine($"Сумма ряда: {sum}{Environment.NewLine}");
                }
                else
                {
                    Console.WriteLine($"Введенное значение некорректно{Environment.NewLine}");
                }
            }
        }
    }
}