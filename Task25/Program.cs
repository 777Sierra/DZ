﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int b = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }

        Console.WriteLine($"Результат: {result}");
    }
}

//На вход программе сначала подаются два числа A и B. Затем создается переменная result, которая инициализируется единицей. 
//В цикле for происходит умножение числа A на себя B раз, результат каждого умножения сохраняется в переменной result. 
//После окончания цикла на экран выводится результат возведения числа A в степень B.