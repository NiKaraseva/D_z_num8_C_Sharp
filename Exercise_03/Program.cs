/* Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */ 

int[,] array1 = GetArray(3, 3, 1, 5); 
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(3, 3, 1, 5); 
PrintArray(array2);
Console.WriteLine();

int[,] array3 = NewMatrix(array1, array2);
PrintArray(array3);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] NewMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(0); j++)
        {
            for(int k = 0; k < array2.GetLength(1); k++)
            {
                result[i, k] += array1[i, j] * array2[j, k];
            }
        }
    }
    return result;
}