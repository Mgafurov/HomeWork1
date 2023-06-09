// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        // Ввод элементов массива с клавиатуры
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Введите элемент [{0}, {1}]: ", i, j);
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Сортировка элементов массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        if (array[x, y] > array[i, j])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[x, y];
                            array[x, y] = temp;
                        }
                    }
                }
            }
        }

        // Вывод отсортированного массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
