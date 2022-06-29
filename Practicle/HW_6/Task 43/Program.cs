// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями:
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  x = (b2-b1)/(k1-k2)
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double k1 = new Random().Next(0, 10);
double b1 = new Random().Next(0, 10);
double k2 = new Random().Next(0, 10);
double b2 = new Random().Next(0, 10);
Console.WriteLine();
Console.WriteLine($"Если b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}, то:");
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("прямые совпадают (бесконечное множество точек пересечения).");
    return;
}
if (k1 - k2 == 0)
    {
        Console.WriteLine("прямые не пересекаются (прямые параллельны).");
        return;
    }
double y = 0;
double x = (b2 - b1) / (k1 - k2);
x = Math.Round(x, 2);
y = k1 * x + b1;
Console.WriteLine($"точка пересечения прямых имеет координаты ({x}, {y})");
Console.WriteLine();