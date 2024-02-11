// Задача 19 (дом). Прога принимает на вход пятизначное число, и проверяет яв-ся ли оно палиндромом.

// Применительно к массивам, которые могут содержать ещё и Буквы и Символы, код такой:
// 
/*
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
}                                               // */
   
// Применительно к числам (только к пятизначым числам), код такой:
// 
/*
Console.WriteLine ("Введите пятизначное число (от 10'000 до 99'999 или от -10'000 до -99'999): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100000 != 0 || number/10000 == 0)
{
    Console.Write("Число не пятизначное.");
}
else if (number/10000 == number%10 && (number/1000)%10 == (number/10)%10 && number>0)
{
     Console.Write("Число - палиндром.");
}
else Console.Write("Число Не яв-ся палиндромом.");                    // */

// код для автотеста:
// /*
Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
static bool IsPalindrome (int number) {
// - Начало блока для копирования:
if (number/100000 != 0 || number/10000 == 0)
  {
    Console.WriteLine("Число не пятизначное");
    return false;
  }
else
{
  if (number/10000 == number%10 && (number/1000)%10 == (number/10)%10 && number>0)
  return true;
  else return false;
}
// - Конец блока для копирования
}
Console.WriteLine(IsPalindrome(number));                            // */