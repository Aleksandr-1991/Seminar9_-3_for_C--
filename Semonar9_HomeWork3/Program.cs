// (Зад. №23, Дом). Напишите прог-у, кот приним на вход число (N),
// и выдаёт таблицу кубов чисел - от 1 до N.

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
         Console.WriteLine($"Для {i} куб = {i*i*i};");
    }
}