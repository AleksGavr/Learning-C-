/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

string UserArray = "";
string Array(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            array[i] = new Random().Next(-100, 100);
            UserArray = UserArray + array[i].ToString() + " -> [";
            break;
        }
        else
        {
            array[i] = new Random().Next(-100, 100);
            UserArray = UserArray + array[i].ToString() + ", ";
        }
    }
    for (int i = 0; i < length; i++)
    {
        if (i == 0 && i == array.Length - 1)
        {
            UserArray = UserArray + " [" + array[i].ToString() + "]";
            return UserArray;
        }
    
        if (i == array.Length - 1)
        {
            UserArray = UserArray + array[i].ToString() + "]";
            return UserArray;
        }
        else
        {
            UserArray = UserArray + array[i].ToString() + ", ";
        }
    }
return UserArray;
}

Console.WriteLine(Array(length));