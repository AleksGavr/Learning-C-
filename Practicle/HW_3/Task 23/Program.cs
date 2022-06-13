// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"{N} -> ");

int a = 1;
while (a <= N)
{
    if (a == N)
    {
        Console.Write($"{Math.Pow(a, 3)}");
        break;
    }
    {
        Console.Write($"{Math.Pow(a, 3)}, ");
        a++;
    }
}
