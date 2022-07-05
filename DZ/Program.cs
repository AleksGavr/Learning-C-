/* // Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] matrix = new int[row, column];
Console.WriteLine("Исходный массив: ");
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
Console.WriteLine(); */


/* // Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] matrix = new int[row, column];
Console.WriteLine("Массив: ");

PrintArray(matrix);

int[] sum = new int[row];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sumrow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumrow += matrix[i, j];
    }
    sum[i] = sumrow;
}
int ind = 0;
int minsumrow = sum[0];
for (int i = 1; i < sum.Length; i++)
    if (minsumrow > sum[i])
    {
        minsumrow = sum[i];
        ind = i;
    }
Console.WriteLine($"В строке {ind + 1} наименьшая сумма элементов.");
Console.WriteLine(); */


/* // Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Введите количество строк матрицы А: ");
int rowA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int columnA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк матрицы В: ");
int rowB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int columnB = int.Parse(Console.ReadLine());

if (columnA != rowB)
{
    Console.WriteLine("Произведение данных матриц не коммутативно");
    return;
}
Console.WriteLine();
int[,] matrixA = new int[rowA, columnA];
Console.WriteLine("Матрица А: ");
PrintArray(matrixA);

int[,] matrixB = new int[rowB, columnB];
Console.WriteLine("Матрица B: ");
PrintArray(matrixB);

int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
Console.WriteLine("Произведение матриц А и В: ");

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int k = 0; k < matrixB.GetLength(0); k++)
        {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        Console.Write($"{matrixC[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine(); */