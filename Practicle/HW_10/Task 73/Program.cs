// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// 25 мин
// Например, для N = 50, M получается 6
// - Группа 1: 1
// - Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// - Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// - Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// - Группа 5: 7 16 24 36 40
// - Группа 6: 5 32 48

int InputNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

int[] Mass(int n)
{
  int[] temp = new int[n];
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = i + 1;
  }
  return temp;
}

string PrintFillArray(int[] array)
{
  string result = string.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] != 0) result += $"{array[i],1} ";
  }
  return result;
}

void MakeRow(int[] masstest)
{
  int[] masstemp = new int[masstest.Length];
  int num = 1;
  int count = 0;
  int tempnum1 = 0;
  int tempnum2 = 0;
  int move = 0;
  
  for (int i = 0; i < masstest.Length; i++)
  {
    Array.Clear(masstemp);
    count = 0;
    if (masstest[i] != 0)
    {
      masstemp[count] = masstest[i];
      tempnum2 = masstest[i];

      for (int j = i; j < masstest.Length; j++)
      {
        if (masstest[j] % tempnum2 != 0 || masstest[j] / tempnum2 == 1)
        {
          move = 0;
          tempnum1 = masstest[j];
          for (int k = 0; k < count; k++)
          {
            if (tempnum1 % masstemp[k] == 0) move++;
          }
          if (move == 0)
          {
            masstemp[count] = masstest[j];
            count++;
            masstest[j] = 0;
          }
        }
      }
      Console.WriteLine($"Группа {num++}: {PrintFillArray(masstemp)}");
    }
  }
}

Console.Clear();
int specnum = InputNumbers("Введите число N: ");

int[] tempmass = Mass(specnum);
MakeRow(tempmass);