/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */



int[] arr = GetArray1(10, 99, 8);


int[,,] array3 = NewArray3(2, 2, 2, arr); 
PrintArray(array3); 


int[] GetArray1(int minValue, int maxValue, int size)
{
    int[] array1 = new int[size];
    for (int h = 0; h < size; h++)
    {
        bool isUnique;
        do
        {
            array1[h] = new Random().Next(minValue, maxValue + 1);
            isUnique = true;
            for (int j = 0; j < h; j++)
                if (array1[h] == array1[j])
                {
                    isUnique = false;
                    break;
                }
        } while (!isUnique);
    }
    return array1;
}

int [,,] NewArray3(int x, int y, int z, int[] arr)
{
    int[,,] result = new int [x, y, z];
    int h = 0;
    int lenght = arr.Length;
    while(h < lenght)
    {
        for(int i = 0; i < x; i++)
        {
            for(int j = 0; j < y; j++)
            {
                for(int k = 0; k < z; k++)
                {
                    result[i, j, k] = arr[h];
                    h++;
                }
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
