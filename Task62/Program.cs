using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[4, 4];
        int n = 4;
        int num = 1;
        for (int i = 0; i < n / 2; i++)
        {
            // заполняем верхнюю строку
            for (int j = i; j < n - i; j++)
            {
                arr[i, j] = num++;
            }
            // заполняем правый столбец
            for (int j = i + 1; j < n - i; j++)
            {
                arr[j, n - i - 1] = num++;
            }
            // заполняем нижнюю строку
            for (int j = n - i - 2; j >= i; j--)
            {
                arr[n - i - 1, j] = num++;
            }
            // заполняем левый столбец
            for (int j = n - i - 2; j > i; j--)
            {
                arr[j, i] = num++;
            }
        }
        
        // выводим массив
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}