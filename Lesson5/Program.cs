
namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine($"Введите номер задачи:{Environment.NewLine} 1 - Сумма элементов побочной диагонали матрицы и сумма элементов под этой диагональю{Environment.NewLine}" +
                                                                            $" 2 - Все вхождения в строке, кроме первого и последнего, символы \"h\" заменить на \"H\"{Environment.NewLine}" +
                                                                            $" 3 - Шифровать строку с помощью шифра Цезаря{Environment.NewLine}" +
                                                                            $" 4 - Дешифровать строку с помощью шифра Цезаря{Environment.NewLine}" +
                                                                            $" 0 - Выход{Environment.NewLine}"); ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1:
                            SumOfSideDiagonal(GetSquareMatrixFromConsole());
                            break;
                        case 2:
                            ReplaceH();
                            break;
                        case 3:
                            CaesarEncryptor();
                            break;
                        case 4:
                            CaesarDecryptor();
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

            int[][] GetSquareMatrixFromConsole()
            {
                while (true)
                {
                    Console.WriteLine("Введите длину строки квадратной матрицы (не меньше двух): ");
                    if (int.TryParse(Console.ReadLine(), out int rowLength) & rowLength > 1)
                    {
                        int[][] inputMatrix = new int[rowLength][];
                        for (int i = 0; i < rowLength; i++)
                        {
                            inputMatrix[i] = new int[rowLength];
                            for (int j = 0; j < rowLength; j++)
                            {
                                Console.WriteLine($"Введите значение элемента матрицы строка {i + 1}, столбец {j + 1}: ");
                                if (int.TryParse(Console.ReadLine(), out int matrixElement))
                                {
                                    inputMatrix[i][j] = matrixElement;
                                }
                                else
                                {
                                    Console.WriteLine($"Введено некорректное значение для элемента матрицы строка {i + 1}, столбец {j + 1}. Повторите попытку{Environment.NewLine}");
                                }
                            }
                        }
                        Console.Write($"{Environment.NewLine}Введенная матрица:");
                        for (int i = 0; i < rowLength; i++)
                        {
                            Console.Write($"{Environment.NewLine}");
                            for (int j = 0; j < rowLength; j++)
                            {
                                Console.Write($"{inputMatrix[i][j]} ");
                            }
                        }
                        Console.WriteLine();
                        return inputMatrix;
                    }
                    else
                    {
                        Console.WriteLine($"Введено некорректное значение размерности матрицы. {Environment.NewLine}");
                        continue;
                    }
                }

            }

            void SumOfSideDiagonal(int[][] inputMatrix)
            {
                int sumSideDiagonal = 0;
                int sumUnderSideDiagonal = 0;
                int j;
                for (int i = 0; i < inputMatrix.Length; i++)
                {
                    j = inputMatrix.Length - 1 - i;
                    sumSideDiagonal += inputMatrix[i][j];
                    for (int k = j + 1; k < inputMatrix.Length; k++)
                    {
                        sumUnderSideDiagonal += inputMatrix[i][k];
                    }
                }
                Console.Write($"Сумма элементов побочной диагонали матрицы: {sumSideDiagonal}{Environment.NewLine}Сумма эементов под побочной диагонали матрицы: {sumUnderSideDiagonal}{Environment.NewLine}{Environment.NewLine}");
            }

            void ReplaceH()
            {
                Console.WriteLine("Введите непустую строку, содержащую символ h: ");
                string inputText = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(inputText))
                {
                    if (inputText.Contains('h'))
                    {
                        int inputLength = inputText.Length;
                        if (inputLength > 2)
                        {
                            string resultText = inputText.Substring(0, 1) + inputText.Substring(1, inputLength - 2).Replace('h', 'H') + inputText.Substring(inputLength - 1, 1);
                            Console.WriteLine($"Форматированная строка: {resultText}{Environment.NewLine}");
                        }
                        else
                        {
                            Console.WriteLine($"Введенная строка останется неизменной: {inputText}{Environment.NewLine}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Введенная строка должна содержать символ \"h\"{Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"Введенная строка не должна быть пустой{Environment.NewLine}");
                }
            }

            void CaesarEncryptor()
            {
                string alphabethEng = "abcdefghijklmnopqrstuvwxyz";
                string alphabethRus = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
                Console.WriteLine("Введите число сдвига (ключ) для шифрования: ");
                if (int.TryParse(Console.ReadLine(), out int key))
                {
                    Console.WriteLine("Введите непустую строку для шифрования: ");
                    string inputText = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(inputText))
                    {
                        string alphabethType = "UNDEFINED";
                        string encryptedText = "";
                        int indexMatchEng;
                        int indexMatchRus;
                        for (int i = 0; i < inputText.Length; i++)
                        {
                            switch (alphabethType)
                            {
                                case "UNDEFINED":
                                    indexMatchEng = alphabethEng.IndexOf(char.ToLower(inputText[i]));
                                    indexMatchRus = alphabethRus.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchEng != -1)
                                    {
                                        alphabethType = "ENG";
                                        encryptedText += alphabethEng[(indexMatchEng + key) % alphabethEng.Length];
                                    }
                                    else if (indexMatchRus != -1)
                                    {
                                        alphabethType = "RUS";
                                        encryptedText += alphabethRus[(indexMatchRus + key) % alphabethRus.Length];
                                    }
                                    else
                                    {
                                        encryptedText += inputText[i];
                                    }
                                    break;
                                case "ENG":
                                    indexMatchEng = alphabethEng.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchEng != -1)
                                    {
                                        encryptedText += alphabethEng[(indexMatchEng + key) % alphabethEng.Length];
                                    }
                                    else
                                    {
                                        encryptedText += inputText[i];
                                    }
                                    break;
                                case "RUS":
                                    indexMatchRus = alphabethRus.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchRus != -1)
                                    {
                                        encryptedText += alphabethRus[(indexMatchRus + key) % alphabethRus.Length];
                                    }
                                    else
                                    {
                                        encryptedText += inputText[i];
                                    }
                                    break;
                            }
                        }
                        Console.WriteLine($"Зашифрованная строка: {Environment.NewLine}{encryptedText}");
                    }
                    else
                    {
                        Console.WriteLine($"Введенная строка не должна быть пустой{Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"Введенное значение не является целым числом{Environment.NewLine}");
                }
            }

            void CaesarDecryptor()
            {
                string alphabethEng = "abcdefghijklmnopqrstuvwxyz";
                string alphabethRus = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
                Console.WriteLine("Введите число сдвига (ключ) для дешифрования: ");
                if (int.TryParse(Console.ReadLine(), out int key))
                {
                    Console.WriteLine("Введите непустую строку для дешифрования: ");
                    string inputText = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(inputText))
                    {
                        string alphabethType = "UNDEFINED";
                        string decryptedText = "";
                        int indexMatchEng;
                        int indexMatchRus;
                        for (int i = 0; i < inputText.Length; i++)
                        {
                            switch (alphabethType)
                            {
                                case "UNDEFINED":
                                    indexMatchEng = alphabethEng.IndexOf(char.ToLower(inputText[i]));
                                    indexMatchRus = alphabethRus.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchEng != -1)
                                    {
                                        alphabethType = "ENG";
                                        decryptedText += alphabethEng[(indexMatchEng - key) % alphabethEng.Length];
                                    }
                                    else if (indexMatchRus != -1)
                                    {
                                        alphabethType = "RUS";
                                        decryptedText += alphabethRus[(indexMatchRus - key) % alphabethRus.Length];
                                    }
                                    else
                                    {
                                        decryptedText += inputText[i];
                                    }
                                    break;
                                case "ENG":
                                    indexMatchEng = alphabethEng.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchEng != -1)
                                    {
                                        decryptedText += alphabethEng[(indexMatchEng - key) % alphabethEng.Length];
                                    }
                                    else
                                    {
                                        decryptedText += inputText[i];
                                    }
                                    break;
                                case "RUS":
                                    indexMatchRus = alphabethRus.IndexOf(char.ToLower(inputText[i]));
                                    if (indexMatchRus != -1)
                                    {
                                        decryptedText += alphabethRus[(indexMatchRus - key) % alphabethRus.Length];
                                    }
                                    else
                                    {
                                        decryptedText += inputText[i];
                                    }
                                    break;
                            }
                        }
                        Console.WriteLine($"Зашифрованная строка: {Environment.NewLine}{decryptedText}");
                    }
                    else
                    {
                        Console.WriteLine($"Введенная строка не должна быть пустой{Environment.NewLine}");
                    }
                }
                else
                {
                    Console.WriteLine($"Введенное значение не является целым числом{Environment.NewLine}");
                }
            }
        }

    }
}