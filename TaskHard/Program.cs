//  Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 5, 3, 4, 1, 7, 8, 15, 1 };
        int[] longestIncreasingSequence = FindLongestIncreasingSequence(numbers);

        Console.WriteLine("Максимальная сплошная возрастающая последовательность:");
        foreach (int num in longestIncreasingSequence)
        {
            Console.Write(num + " ");
        }
    }

    static int[] FindLongestIncreasingSequence(int[] numbers)
    {
        List<int> sequence = new List<int>();
        List<int> longestSequence = new List<int>();

        foreach (int num in numbers)
        {
            if (sequence.Count == 0 || num > sequence[sequence.Count - 1])
            {
                sequence.Add(num);
            }
            else
            {
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(sequence);
                }
                sequence.Clear();
                sequence.Add(num);
            }
        }

        if (sequence.Count > longestSequence.Count)
        {
            longestSequence.Clear();
            longestSequence.AddRange(sequence);
        }

        return longestSequence.ToArray();
    }
}
