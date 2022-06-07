// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"{N} -> ");

if (N % 2 != 0) N = N - 1;

while (i <= N)
{
    if (i == N)
    {
        Console.Write($"{N}");
        break;
    }
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }

    i++;
}