// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int result = new Random().Next(100, 1000);
int result2 = result/10;
int result3 = result2 % 10;

Console.WriteLine($"{result} -> {result3}");