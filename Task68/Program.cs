//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 29

using System;

class Program {
    static void Main(string[] args) {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
    
    static int AckermannFunction(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0) {
            return AckermannFunction(m - 1, 1);
        }
        else {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}