// Задайте массив из вещественных чисел с ненулевой дробной частью,
//найдите разницу между максимальным и минимальным элементом массива


class Program
{
    static void Main()
    {
        double[] numbers = GenerateRandomArray(10, 1, 100);

        Console.WriteLine("Массив из вещественных чисел:");
        PrintArray(numbers);

        double min = numbers[0];
        double max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        double difference = max - min;

        Console.WriteLine("Разница между минимальным и максимальным значениями: " + difference);
    }

    static double[] GenerateRandomArray(int size, double min, double max)
    {
        Random random = new Random();
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.NextDouble() * (max - min) + min;
        }

        return array;
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (T element in array)
        {
            Console.WriteLine(element);
        }
    }
}