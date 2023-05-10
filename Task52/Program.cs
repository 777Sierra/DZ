using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса Random для генерации случайных чисел
        Random rand = new Random();

        // Задаем размеры массива
        int m = 3;
        int n = 4;

        // Создаем двумерный массив из случайных целых чисел
        int[,] arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(1, 10); // генерируем случайное целое число от 1 до 10
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Находим среднее арифметическое элементов в каждом столбце
        double[] avg = new double[n];
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += arr[i, j];
            }
            avg[j] = (double)sum / m;
        }

        // Выводим средние арифметические на экран
        Console.WriteLine("Средние арифметические элементов в каждом столбце:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {avg[j]}");
        }
    }
}