// Зад№17. Прога: На вход коор-ты точки (X и Y). Причём X!=0 и Y!=0.
// И выдаёт № четверти плоскости, в кот нах-ся эта точка.
// 1. Ввод X и Y.
// 2. Определить четверть, основываясь на X и Y.

// Console.WriteLine("Введите X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int y = Convert.ToInt32(Console.ReadLine());
int[] array = new int[2];
Console.WriteLine("Введите X и Y");
for (int i=0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

if (array[0]>0 && array[1]>0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
else if (array[0]<0 && array[1]>0)
{
    Console.WriteLine("Точка находится в 2 четверти");
}
else if (array[0]<0 && array[1]<0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
else if (array[0]>0 && array[1]<0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
else
{
    Console.WriteLine("X=0 или Y=0");
}