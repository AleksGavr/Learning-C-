﻿/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2

void Array(int[] arr)
{
    Console.Write("[");
    int i = 0;
    while (i < arr.Length + 1)
    {
        if (i == arr.Length -1)
        {
            arr[i] = new Random().Next(100, 1000);
            Console.Write($"{arr[i]}]");
            break;
        }
        else
        {
            arr[i] = new Random().Next(100, 1000);
            Console.Write($"{arr[i]}, ");
        }
        i++;
    }
}
Console.Write("Ввведите длину массива: ");
int[] mass = new int[int.Parse(Console.ReadLine())];
Array(mass);

int count =0;
for(int i =0; i<mass.Length;i++)
{
    if(mass[i]%2==0)
    {
        count+=1;
    }
}
Console.Write($" -> {count}"); */


/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

void Array(int[] arr)
{
    Console.Write("[");
    int i = 0;
    while (i < arr.Length + 1)
    {
        if (i == arr.Length - 1)
        {
            arr[i] = new Random().Next(-10, 10);
            Console.Write($"{arr[i]}]");
            break;
        }
        else
        {
            arr[i] = new Random().Next(-10, 10);
            Console.Write($"{arr[i]}, ");
        }
        i++;
    }
}
Console.Write("Ввведите длину массива: ");
int[] mass = new int[int.Parse(Console.ReadLine())];
Array(mass);

int SumOdd = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < 0)
    {
        SumOdd += mass[i];
    }
}
Console.Write($" -> {SumOdd}"); */