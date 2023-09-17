// Напишите прог-у, кот приним на вход координаты двух точек 
// и находит расст. меж ними в 3D-пространстве.
Console.Write ("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату X для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z1 - z2) * (z1 - z2));
Console.Write("Расстояние между точками: " + L);