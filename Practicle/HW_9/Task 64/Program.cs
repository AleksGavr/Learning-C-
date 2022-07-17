// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintM(int m, int n)
{
    if (m > n) return;
    Console.Write(m + " ");
    PrintM(m + 1, n);
}
void PrintN(int m, int n)
{
    if (m < n) return;
    Console.Write(m + " ");
    PrintN(m - 1, n);
}

Console.Clear();
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

if (m < n) PrintM(m, n);
if (m > n) PrintN(m, n);
else return;