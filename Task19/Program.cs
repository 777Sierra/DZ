﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Ошибка: введено не пятизначное число.");
            return;
        }

        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }
}