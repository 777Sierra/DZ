using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите значение M:");
        int M;
        while (!int.TryParse(Console.ReadLine(), out M) || M < 1) {
            Console.WriteLine("Некорректный ввод. Введите целое число больше 0:");
        }
        
        Console.WriteLine("Введите значение N:");
        int N;
        while (!int.TryParse(Console.ReadLine(), out N) || N < M) {
            Console.WriteLine($"Некорректный ввод. Введите целое число не меньше {M}:");
        }
        
        PrintNumbersInRange(M, N);
        int sum = GetSumOfNumbersInRange(M, N);
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");
    }
    
    static void PrintNumbersInRange(int start, int end) {
        for (int i = start; i <= end; i++) {
            Console.WriteLine(i);
        }
    }
    
    static int GetSumOfNumbersInRange(int start, int end) {
        int sum = 0;
        for (int i = start; i <= end; i++) {
            sum += i;
        }
        return sum;
    }
}