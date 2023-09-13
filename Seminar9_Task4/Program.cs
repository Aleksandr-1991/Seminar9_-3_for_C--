// Зад. №21 (в группах). Напиши прогу, к-ая принимает на вход коор-ты двух точек
// и находит расстояние меж ними в 2D пространстве.
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Введите x1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("Введите x2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());

// Double D = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);
Double D = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);   // c округлением.
Console.Write(D);   // Math.Ceiling - окрвверх;  Math.floor - окрвниз.