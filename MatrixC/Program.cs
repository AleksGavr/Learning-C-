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
Console.WriteLine();