// Зад №23 Дом. Прога приним на вход число (N), и выдаёт таблицу кубов чисел - от 1 до N.
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
// 
/*  
public class Answer {
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Cube(i));
        }
    }
    public static int Cube(int number)
    {
        return number * number * number;
    }
      static public void Main(string[] args) {
        int N;
        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
            N = 6;
        }
        ShowCube(N);
    }
}                            //*/