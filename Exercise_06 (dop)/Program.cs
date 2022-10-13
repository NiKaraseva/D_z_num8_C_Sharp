/* Отсортировать нечетные столбцы массива по возрастанию. 
Вывести массив изначальный и массив с отсортированными нечетными столбцами */


int[,] array = GetArray(4, 4, 1, 9); 
PrintArray(array);
Console.WriteLine();

int[,] result = Sort(array);
PrintArray(result);


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

int[,] Sort(int[,] array)
{
    int temp;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = array.GetLength(1); k > 0; k--)
        {
            for(int i = 0; i < array.GetLength(0) - 1; i ++)
            {
                if(j % 2 == 0)
                {
                    if(array[i, j] > array[i + 1, j])
                    {
                        temp = array[i + 1, j];
                        array[i + 1, j] = array[i, j];
                        array[i, j] = temp; 
                    }
                }
            }
        }
    }
    return array;
}