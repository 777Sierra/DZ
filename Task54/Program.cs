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

        // Создаем двумерный массив со случайными целыми значениями
        int[,] arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(1, 10); // генерируем случайное целое число от 1 до 10
            }
        }

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Упорядочиваем по убыванию элементы каждой строки
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (arr[i, j] < arr[i, k])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // Выводим упорядоченный массив на экран
        Console.WriteLine("Упорядоченный массив:");
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