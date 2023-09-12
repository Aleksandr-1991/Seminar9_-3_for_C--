// Зад. №22 (в группах). Напиши прогу, к-ая принимает на вход число (N) 
// и выдаёт на выход таблицу квадратов от 1 до N.
Console.Write("Введите натуральное число: ");
Double N = Convert.ToDouble(Console.ReadLine());
if (N < 1 || N%1 > 0)
{
    Console.Write("Нужно было ввести Натуральное число!");
}
else 
{
    for (int i = 1; i <= N; i++)
    {
         Console.WriteLine($"Для {i} квадрат = {i*i};");
    }
}
