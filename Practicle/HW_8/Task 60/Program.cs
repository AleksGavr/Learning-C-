// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

void PrintArray(int[,,] mass)
{
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
    //   Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < mass.GetLength(2); k++)
      {
        Console.Write( $"({i}, {j}, {k}) = {mass[i,j,k]} ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void PrintFillArray(int[,,] mass)
{
    int[] temp = new int[mass.GetLength(0) * mass.GetLength(1) * mass.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < mass.GetLength(0); x++)
    {
        for (int y = 0; y < mass.GetLength(1); y++)
        {
            for (int z = 0; z < mass.GetLength(2); z++)
            {
                mass[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
Console.Clear();
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] mass = new int[x, y, z];
PrintFillArray(mass);
PrintArray(mass);