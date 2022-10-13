/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int[,,] array = GetArray(2, 2, 2, 1, 10); 
PrintArray(array);  
Console.WriteLine();

int[,,] NewArray = CheckDublicate(array, 1, 10);
PrintArray(NewArray);


int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if (k == 0)
                {
                    Console.Write($"{array[i, j, k]} {(i, j, k)} ");
                }
                else
                {
                    Console.WriteLine($"{array[i, j, k]} {(i, j, k)} ");
                }
            }
        }
    }
}


int[,,] CheckDublicate(int[,,] array, int minValue, int maxValue)
{
    for(int x = array.GetLength(0); x > 0; x--)
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int y = array.GetLength(1); y > 0; y--)
            {
                for(int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    for(int z = array.GetLength(2); z > 0; z--)
                    {
                        for(int k = 0; k < array.GetLength(2) - 1; k++)
                        {
                            if(array[i, j, k] == array[i, j, k + 1])
                            {
                                array[i, j, k + 1] = new Random().Next(minValue, maxValue + 1);
                            }
                        }
                    }
                }
            }
        }
        
    }
    return array;
}
   