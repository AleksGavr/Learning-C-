// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

void Array(double[] arr)
{
    Console.Write("[");
    int i = 0;
    while (i < arr.Length + 1)
    {
        if (i == arr.Length - 1)
        {
            arr[i] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 2);
            Console.Write($"{arr[i]}]");
            break;
        }
        else
        {
            arr[i] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 2);
            Console.Write($"{arr[i]}, ");
        }
        i++;
    }
}
Console.Write("Ввведите длину массива: ");
double[] mass = new double[int.Parse(Console.ReadLine())];
Array(mass);

double min = mass[0];
double max = mass[0];
for (int i = 1; i < mass.Length; i++)
{
    if (mass[i] > max) max = mass[i];
    if (mass[i] < min) min = mass[i];
}
double diff = max - min;
Console.Write($" -> {diff}");