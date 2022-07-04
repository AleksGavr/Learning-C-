// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintFillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] matrix = new int[row, column];
Console.WriteLine("Исходный массив: ");
PrintFillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Массив после сортировки по строкам: ");
int[] mass = new int[column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        mass[j] = matrix[i, j];
    }
    for (int n = 0; n < column; n++)
    {
        for (int m = 0; m < column - n - 1; m++)
        {
            if (mass[m] < mass[m + 1])
            {
                int temp = mass[m];
                mass[m] = mass[m + 1];
                mass[m + 1] = temp;
            }
        }

    }
    for (int n = 0; n < mass.Length; n++)
    {
        Console.Write(mass[n] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();