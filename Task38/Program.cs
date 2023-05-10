//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса Random для генерации случайных чисел
        Random rand = new Random();

        // Задаем размер массива
        int n = 10;

        // Создаем массив с рандомными значениями
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Math.Round(rand.NextDouble() * 10, 2); // генерируем случайное вещественное число от 0 до 10 и округляем до сотых долей
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (double elem in arr)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();

        // Находим максимальный и минимальный элементы массива
        double max = arr[0];
        double min = arr[0];
        foreach (double elem in arr)
        {
            if (elem > max)
            {
                max = elem;
            }
            if (elem < min)
            {
                min = elem;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double diff = Math.Round(max - min, 2); // округляем до сотых долей

        // Выводим результат на экран
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);
    }
}