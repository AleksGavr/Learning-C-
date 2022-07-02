// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
Console.Write("Введите количество строк матрицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr = new int[row, column];

for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
        arr[i, j] = new Random().Next(1, 10);

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
        Console.Write(arr[i, j] + " ");
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Среднеее арифмитическое каждого столбца: ");
for (int i = 0; i < column; i++)
{
    double sum = 0;
    for (int j = 0; j < row; j++)
    {
        sum += arr[j, i];
    }
    double aver = sum/row;
    double result = Math.Round(aver, 1);
    Console.Write(result + "; ");
}
Console.WriteLine();
Console.WriteLine();