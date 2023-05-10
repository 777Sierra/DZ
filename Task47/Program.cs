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

        // Создаем двумерный массив с рандомными значениями, округленными до десятичного значения
        double[,] arr = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = Math.Round(rand.NextDouble() * 10, 1); // генерируем случайное вещественное число от 0 до 10 и округляем до десятичного значения
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
    }
}