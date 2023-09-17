// Задача 19 (дом). Напишите прог-у, кот принимает на вход пятизначное число,
// и проверяет яв-ся ли оно палиндромом.


// Применительно к массивам, которые могут содержать ещё и Буквы и Символы, код такой:

string [] array = new string[5];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("Введите " + (i+1) + "-ю цифру или символ пятичленного массива: ");
    array[i] = Console.ReadLine();
}
Console.Write("Получился массив:  ");
for (int j = 0; j < array.GetLength(0); j++)
{
    Console.Write(array[j]);
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.Write(" - Это палиндром.");
}
else 
{
    Console.Write(" - Это Не палиндром.");
}
   
// Применительно к числам (только к пятизначым числам), код такой:
Console.WriteLine ("Введите пятизначное число (от 10'000 до 99'999 или от -10'000 до -99'999): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N/100000 != 0 || N/10000 == 0)
{
    Console.Write("Число не пятизначное");
    Console.Write("False");
}
else if (N/10000 == N%10 && (N/1000)%10 == (N/10)%10 && N>0)
{
    Console.Write("True");
}
else 
{
    Console.Write("False");
}