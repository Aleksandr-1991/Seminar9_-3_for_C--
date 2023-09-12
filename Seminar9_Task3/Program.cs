// Зад. №22 (в группах). Напиши прогу, к-ая принимает на вход число (N) 
// и выдаёт на выход таблицу квадратов от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Для ", i, " квадрат = ", i*i);
}