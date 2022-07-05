// Задача 56: Задайте прямоугольный двумерный массив. Напишите
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
Console.WriteLine();