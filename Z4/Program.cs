// Создать двумерный массив n строк, m столбцов
// Найти элементы у которых оба индекса четные и заменить их на их квадрат

using System;
using static System.Console;
Console.Clear();


int[,] startArray = GetRandomArray(4, 4, 1, 10);
PrintArray(startArray);
Console.WriteLine();
startArray = ChangeArray(startArray);
PrintArray(startArray);

int[,] GetRandomArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            result[i, j] = new Random().Next(min, max);
    }
    return result;
}






int[,] ChangeArray(int [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}