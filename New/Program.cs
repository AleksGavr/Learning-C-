﻿/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void Array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            arr[i] = new Random().Next(-9, 10);
            Console.Write($"{arr[i]}] -> ");
            return;
        }
        else
        {
            arr[i] = new Random().Next(-9, 10);
            Console.Write($"{arr[i]}, ");
        }
    }
}
Console.Write("Ввведите длину массива: ");
int[] mass = new int[int.Parse(Console.ReadLine())];
Array(mass);

Console.Write("[");
for (int i = 0; i < mass.Length; i++)
{
    if (i == mass.Length - 1)
    {
        mass[i] = mass[i] * -1;
        Console.Write($"{mass[i]}]");
        return;
    }
    else
    {
        mass[i] = mass[i] * -1;
        Console.Write($"{mass[i]}, ");
    }
}


/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

// Console.Write("Введите длину массива: ");
// int length = int.Parse(Console.ReadLine());
// Console.Write("Задайте искомое число: ");
// int desired = int.Parse(Console.ReadLine());


// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();

// }

/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */



/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */