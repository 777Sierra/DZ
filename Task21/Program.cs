using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координаты точки A (x,y,z): ");
        string[] aCoords = Console.ReadLine().Split(',');
        double aX = double.Parse(aCoords[0]);
        double aY = double.Parse(aCoords[1]);
        double aZ = double.Parse(aCoords[2]);

        Console.Write("Введите координаты точки B (x,y,z): ");
        string[] bCoords = Console.ReadLine().Split(',');
        double bX = double.Parse(bCoords[0]);
        double bY = double.Parse(bCoords[1]);
        double bZ = double.Parse(bCoords[2]);

        double distance = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2));

        Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");
    }
}