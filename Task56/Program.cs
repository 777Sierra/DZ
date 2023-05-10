using System;

class Program
{
    static void Main(string[] args)
    {
        // создаем двумерный массив 5x5 со случайными значениями от -10 до 10
        int[,] arr = new int[5, 5];
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = rnd.Next(-10, 11);
            }
        }

        // выводим массив на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0,3} ", arr[i, j]);
            }
            Console.WriteLine();
        }

        // находим строку с наименьшей суммой элементов
        int minSum = int.MaxValue; // начальное значение для поиска минимума
        int minSumIndex = -1;
        for (int i = 0; i < 5; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += arr[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumIndex = i;
            }
        }

        // выводим результат
        Console.WriteLine("Строка с наименьшей суммой элементов:");
        for (int j = 0; j < 5; j++)
        {
            Console.Write("{0,3} ", arr[minSumIndex, j]);
        }
        Console.WriteLine();
    }
}