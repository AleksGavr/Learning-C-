// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintFillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[5, 10];
PrintFillArray(matrix);

Console.Write("Введите порядковый номер строки на которой расположен  элемент: ");
int row = int.Parse(Console.ReadLine());
int i = row - 1;
if (i < 0)
{
    Console.Write("Некорректный ввод. Введите число больше 0");
    return;
}
Console.Write("Введите порядковый номер столбца в котором расположен  элемент: ");
int column = int.Parse(Console.ReadLine());
int j = column - 1;
if (j < 0)
{
    Console.Write("Некорректный ввод. Введите число больше 0");
    return;
}
if (row < 6 && column < 11)
{
    Console.WriteLine($"На позиции {row},{column} расположено число {matrix[i, j]}.");
}
else
{
    Console.WriteLine($"Позиции {row},{column} не существует в данном массиве.");
}
Console.WriteLine();
Console.WriteLine();
