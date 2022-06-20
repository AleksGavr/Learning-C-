/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int sum = 0;
int temp = N;
int SumNum(int N)
{
    while (temp > 0)
    {
        sum = sum + temp % 10;
        temp = temp / 10;
    }
    return sum;
}

Console.Write($"{N} -> {SumNum(N)}");