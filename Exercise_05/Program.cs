/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */ 

int[,] matrix = Spiral(4, 4);
PrintArray(matrix);


int[,] Spiral(int m, int n)
{
    int[,] result = new int[m, n];
    int count = 11;
    for(int j = 0; j < n; j++)
    {
        result[0, j] = count;
        count++;
    }
    for(int i = 1; i < m; i++)
    {
        result[i, n - 1] = count;
        count++; 
    }
    for(int j = n - 2; j >= 0; j--)
    {
        result[m - 1, j] = count;
        count++;
    }
    for(int i = m - 2; i > 0; i--)
    {
        result[i, 0] = count;
        count++;
    }
    for(int j = 1; j < n - 1; j++)
    {
        result[1, j] = count;
        count++;
    }
    for(int j = n - 2; j > 0; j--)
    {
        result[2, j] = count;
        count++;
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}