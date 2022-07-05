



int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];

for (int i = 0; i < ar1.GetLength(0); ++i)
    for (int j = 0; j < ar2.GetLength(0); ++j)
        for (int k = 0; k < ar2.GetLength(1); ++k)
            m[i, k] += ar1[i, j] * ar2[j, k];
return m;


int[,] ar1 = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] ar2 = { { 2, 4, 3, 2 }, { 1, 5, 4, 3 }, { 2, 3, 1, 4 } };

int[,] m = mult(ar1, ar2);

for (int i = 0; i < ar1.GetLength(0); ++i)
{
    for (int j = 0; j < ar2.GetLength(1); ++j)
    {
        Console.Write(m[i, j] + " ");
    }
    Console.WriteLine();
}




