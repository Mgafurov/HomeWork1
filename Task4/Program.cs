// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Введите значение элемента: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;
        int positionRow = -1;
        int positionColumn = -1;

        // Поиск значения в массиве
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == target)
                {
                    found = true;
                    positionRow = i;
                    positionColumn = j;
                    break;
                }
            }

            if (found)
            {
                break;
            }
        }

        // Вывод результата
        if (found)
        {
            Console.WriteLine("Значение {0} найдено в позиции [{1}, {2}].", target, positionRow, positionColumn);
        }
        else
        {
            Console.WriteLine("Значение {0} не найдено в массиве.", target);
        }
    }
}
