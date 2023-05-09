using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел:");
        PrintCubes(n);
    }

    static void PrintCubes(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int cube = Cube(i);
            Console.Write($"{cube} ");
        }
    }

    static int Cube(int x)
    {
        return x * x * x;
    }
}
