// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через пробел: ");
string[] userinput = Console.ReadLine().Split(" ");
int amountnum = userinput.Length;
int posnum = 0;
for (int i = 0; i < userinput.Length; i++)
{
    int num = int.Parse(userinput[i]);
    if (num > 0) posnum++;
}
Console.Write($"Введено {amountnum} чисел. Из них больше 0: {posnum}");