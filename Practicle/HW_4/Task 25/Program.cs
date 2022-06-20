/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую надо возвести число: ");
int power = int.Parse(Console.ReadLine());

int NumPower(int power)
{
    int i = 1;
    int result = 1;
    while (i <= power)
    {
        result = result * num;
        i++;
    }
    return result;
}

Console.Write($"{num}, {power} -> {NumPower(power)}");