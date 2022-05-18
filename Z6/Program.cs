// Создать двумерный массив n строк, m столбцов
// Найти сумму главной диагонали
using System;
using static System.Console;
Console.Clear();


int[,] startArray = GetRandomArray(4, 5, 1, 10);
PrintArray(startArray);
WriteLine(GetSumDiag(startArray));

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






int GetSumDiag(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);

    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
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