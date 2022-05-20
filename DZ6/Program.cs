//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;
Console.Clear();

Console.Write("Введите количество строк n=");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов m=");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(n, m, 0, 100);
double[] sum = new double[m];
PrintArray(array);

int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(0, 100);
        }
    }
    return result;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[j] += array[i, j];
    }
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{(sum[j] / m),1} ");
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
