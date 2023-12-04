// Зад №21. Прога принимает коор-ты двух точек и находит расстояние меж ними в 2D пространстве.
// (здесь удалить перенос строки, чтобы раскомментировать блок кода ниже): 
/*
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Введите x1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("Введите x2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());    // */    // - первая простая запись вводимых координат

double [] A = new double [2];
double [] B = new double [2];
for (int i = 0; i<2; i++)
{
    Console.Write($"Введите {i+1}-ую координату точки А: ");
    A[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i<2; i++)
{
    Console.Write($"Введите {i+1}-ую координату точки B: ");
    B[i] = Convert.ToDouble(Console.ReadLine());
}          // Math.Pow(а, b) - возведение в степень ("а" в "b").
// Double D = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
Double D = Math.Round(Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2)), 3);
Console.Write(D);    // Math.Round - c округлением.  Math.Ceiling - окрвверх.  Math.Floor - окрвниз.