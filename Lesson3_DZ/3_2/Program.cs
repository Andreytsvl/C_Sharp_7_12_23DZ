// Задайте массив на 10 целых чисел, напишите программу, которая определяет к-во целых чисел
using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(10, 1, 100);

        Console.WriteLine("Массив из 10 случайных чисел:");
        PrintArray(numbers);

        int count = CountEvenNumbers(numbers);

        Console.WriteLine("Количество четных чисел: " + count);

        Console.ReadLine();
    }

    // Функция для генерации случайного массива
    static int[] GenerateRandomArray(int size, int min, int max)
    {
        int[] arr = new int[size];
        Random random = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(min, max + 1);
        }

        return arr;
    }

    // Функция для вывода массива
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Функция для подсчета четных
    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
