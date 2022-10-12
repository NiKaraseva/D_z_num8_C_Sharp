/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

int[,] array = GetArray(4, 4, 1, 9); 
PrintArray(array);
Console.WriteLine();

int index = minSumIndex(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов = {index}");


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

int minSumIndex(int[,] array)

{
    int sum = 0;
    int minSum = 0;
    int minIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
            minIndex = 0;
        }
        else 
        {
            if(sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }
        sum = 0;
    }
    return minIndex;
}
        
                    
                
                



