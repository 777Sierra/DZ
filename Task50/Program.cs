using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем двумерный массив
        double[,] arr = { { 1.2, 3.4, 5.6 }, { 7.8, 9.0, 2.4 }, { 6.5, 4.3, 8.1 } };

        // Получаем размеры массива
        int m = arr.GetLength(0);
        int n = arr.GetLength(1);

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

        // Считываем позиции элемента
        Console.Write("Введите номер строки: ");
        int iPos = int.Parse(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        int jPos = int.Parse(Console.ReadLine());

        // Проверяем, существует ли элемент с такими позициями
        if (iPos >= 0 && iPos < m && jPos >= 0 && jPos < n)
        {
            // Выводим значение элемента на экран
            double elem = arr[iPos, jPos];
            Console.WriteLine($"Значение элемента [{iPos}, {jPos}]: {elem}");
        }
        else
        {
            // Выводим сообщение об ошибке на экран
            Console.WriteLine("Элемент с такими позициями не существует.");
        }
    }
}