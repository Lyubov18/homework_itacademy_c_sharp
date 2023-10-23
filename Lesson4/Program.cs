namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine($"Введите номер задачи:{Environment.NewLine} 1 - Сумма элементов массива{Environment.NewLine}" +
                                                                            $" 2 - Разность максимума и минимума в массиве{Environment.NewLine}" +
                                                                            $" 3 - Проверка элементов массива на уникальность{Environment.NewLine}" +
                                                                            $" 0 - Выход{Environment.NewLine}"); ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1:
                            SumOfElements(GetIntArrayFromConsole());
                            break;
                        case 2:
                            DifferenceMaxMin(GetIntArrayFromConsole());
                            break;
                        case 3:
                            UniqueElementsInArray(GetIntArrayFromConsole());
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


            int[] GetIntArrayFromConsole()
            {
                while (true)
                {
                    Console.WriteLine("Введите размер массива (не меньше двух): ");
                    if (int.TryParse(Console.ReadLine(), out int arrayLength) & arrayLength > 1)
                    {
                        int[] inputArray = new int[arrayLength];
                        int i = 0;
                        while (i < arrayLength)
                        {
                            Console.WriteLine($"Введите значение для элемента массива номер {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int arrayElement))
                            {
                                inputArray[i] = arrayElement;
                                i++;
                            }
                            else
                            {
                                Console.WriteLine($"Введено некорректное значение для элемента массива номер {i + 1}. Повторите попытку{Environment.NewLine}");
                            }
                        }
                        Console.Write($"{Environment.NewLine}Введенный массив: ");
                        foreach (int number in inputArray)
                        {
                            Console.Write($"{number} ");
                        }
                        Console.WriteLine();
                        return inputArray;
                    }
                    else
                    {
                        Console.WriteLine($"Введено некорректное значение для размера массива. {Environment.NewLine}");
                        continue;
                    }

                }

            }

            void SumOfElements(int[] inputArray)
            {
                int sum = 0;
                foreach (int number in inputArray)
                {
                    sum += number;
                }
                Console.Write($"Сумма элементов в массиве: {sum}{Environment.NewLine}{Environment.NewLine}");
            }

            void DifferenceMaxMin(int[] inputArray)
            {
                (int min, int max) = (inputArray[0], inputArray[0]);
                foreach (int number in inputArray)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    else if (number > max)
                    {
                        max = number;
                    }
                }
                Console.Write($"Минимальный элемент в массиве: {min}{Environment.NewLine}Максимальный элемент в массиве: {max}{Environment.NewLine}{Environment.NewLine}");
            }

            void UniqueElementsInArray(int[] inputArray)
            {
                int amountOfElements = 1;
                int amountOfDuplicates = 0;
                Array.Sort(inputArray);
                int tempInput = inputArray[0];
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] == tempInput)
                    {
                        amountOfElements++;
                        if (i == inputArray.Length-1)
                        {
                            Console.Write($"Элемент {tempInput} повторяется {amountOfElements} раз/раза {Environment.NewLine}");
                            amountOfDuplicates++;
                        }
                    }
                    else if (amountOfElements > 1)
                    {
                        Console.Write($"Элемент {tempInput} повторяется {amountOfElements} раз/раза {Environment.NewLine}");
                        tempInput = inputArray[i];
                        amountOfElements = 1;
                        amountOfDuplicates++;
                    }
                    else
                    {
                        tempInput = inputArray[i];
                    }
                }
                if (amountOfDuplicates == 0)
                {
                    Console.Write($"В данном массиве нет дубликатов.{Environment.NewLine}{Environment.NewLine}");
                }
                else
                {
                    Console.WriteLine($"Количество повторяющихся элементов: {amountOfDuplicates}{Environment.NewLine}{Environment.NewLine}");
                }
            }


            /*Решение без использования Sort
             * 
             * void UniqueElementsInArray(int[] inputArray)
            {
                int amountOfElements;
                int amountOfDuplicates = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    amountOfElements = 1;
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j])
                        {
                            amountOfElements++;
                            int[] deletedArray = new int[inputArray.Length - 1];
                            for (int k = 0; k < deletedArray.Length; k++)
                            {
                                deletedArray[k] = k < j ? inputArray[k] : inputArray[k + 1];
                            }
                            inputArray = deletedArray;
                            j--;
                        }
                    }
                    if (amountOfElements > 1)
                    {
                        amountOfDuplicates++;
                        Console.Write($"Элемент {inputArray[i]} повторяется {amountOfElements} раз/раза {Environment.NewLine}");
                    }
                }
                if (amountOfDuplicates == 0)
                {
                    Console.Write($"В данном массиве нет дубликатов.{Environment.NewLine}{Environment.NewLine}");
                }
                else 
                {
                    Console.WriteLine($"Количество повторяющихся элементов: {amountOfDuplicates}{Environment.NewLine}{Environment.NewLine}");
                }
            }*/
        }
    }
}