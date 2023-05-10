//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49


//Судя по примеру, задача требует нахождения произведения элементов двух матриц, а не их матричное произведение

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        Random random = new Random();

        Console.WriteLine("Матрица 1:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix1[i, j] = random.Next(1, 10);
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Матрица 2:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix2[i, j] = random.Next(1, 10);
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] resultMatrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }

        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
