﻿//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using System;

class Program
{
    static void Main()
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов

        // Создание генератора случайных чисел
        Random random = new Random();

        // Создание двумерного массива
        double[,] array = new double[m, n];

        // Заполнение массива случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10; // генерация чисел от -10 до 10
            }
        }

        // Вывод массива на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
