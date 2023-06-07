// Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.

// Пример:

// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число k : ");
        int k = int.Parse(Console.ReadLine());
        int[] negaFinobacci = GenerateNegaFinobacci(k);
        System.Console.WriteLine("Массив чисел НегаФинобаччи:");
        foreach(int num in negaFinobacci)
        {
            Console.Write(num + " ");
        }
    }
    static int[] GenerateNegaFinobacci(int k)
    {
        int[] negaFinobacci = new int[k + 2];
        negaFinobacci[0] = -1;
        negaFinobacci[1] = 1;
        for(int i = 2; i <= k + 1; i++)
        {
            negaFinobacci[i] = negaFinobacci[i - 2] - negaFinobacci[i - 1];
        }
        return negaFinobacci;
    }
}     

