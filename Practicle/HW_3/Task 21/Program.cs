// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = new Random().Next(-10, 10);
int x2 = new Random().Next(-10, 10);
int y1 = new Random().Next(-10, 10);
int y2 = new Random().Next(-10, 10);
int z1 = new Random().Next(-10, 10);
int z2 = new Random().Next(-10, 10);

Console.Write($"A ({x1}, {y1}, {z1}); ");
Console.Write($"B ({x2}, {y2}, {z2}) -> ");


double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); 

Console.WriteLine(Math.Round(a, 2));