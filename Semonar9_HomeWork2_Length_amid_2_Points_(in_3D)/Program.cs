// №21. Прога принимает на вход координаты двух точек и находит расст. меж ними в 3D-пространстве.
// /*
Console.Write ("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
// c округлением:  
double L = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 3);
Console.Write("Расстояние между точками: " + L);                     //*/

//  Код для автотеста:
// 
/*
using System;
public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {      // Введите свое решение ниже
double L = Math.Round(Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + Math.Pow((pointA[1] - pointB[1]), 2) + Math.Pow((pointA[2] - pointB[2]), 2)), 2);
return L;
    }
  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;
        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;    x2 = 6;   x3 = 8;
            y1 = 2;    y2 = 1;   y3 = -7;
        }
        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}