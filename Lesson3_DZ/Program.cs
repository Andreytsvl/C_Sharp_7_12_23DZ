// Задайте одномерный массив из 10 целых чисел от 1 до 100
//Найдите к-во элементов массива, значения которых лежат в интервале [20 90]


class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();

      
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

        Console.WriteLine("Массив из 10 случайных чисел:");
        PrintArray(numbers);

        int count = CountNumbersInRange(numbers, 20, 90);

        Console.WriteLine("Количество чисел в интервале: " + count);

        Console.ReadLine();
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

    // Функция для подсчета чисел
    static int CountNumbersInRange(int[] arr, int min, int max)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num >= min && num <= max)
            {
                count++;
            }
        }
        return count;
    }
}
