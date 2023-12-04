// Зад №18 (в группах). Прога по заданному № чертверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
int imput;
while (true)
{
    Console.WriteLine("Введите номер четверти. Число от 1 до 4!");
    imput = Convert.ToInt32(Console.ReadLine());
    if (imput > 0 && imput < 5)  break;
    Console.WriteLine($"Число должно было быть от 1 до 4, а не {imput}, Урук-хай ты эдакий!");
}
switch (imput)
{
    case 1: 
        Console.WriteLine("В таком случае: x>0, y>0");
        break;
    case 2: 
        Console.WriteLine("В таком случае: x<0, y>0");
        break;
    case 3: 
        Console.WriteLine("В таком случае: x<0, y<0");
        break;
    case 4: 
        Console.WriteLine("В таком случае: x>0, y<0");
        break;
}